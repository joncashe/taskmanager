using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoSaaSCRM.ORM;
using System.Data;

namespace ProyectoSaaSCRM
{
    public partial class _Default : System.Web.UI.Page
    {

        public static SaaSCRMEntities entity = dbEntity.getSaaSCRMEntity();

        protected void Page_Load(object sender, EventArgs e)
        {
            loadTasksForToday();
            loadUnfinishedTasks();

            
        }

        private void loadTasksForToday(){
            List<Task> taskList = new List<Task>();
            taskList = entity.Tasks.Where(p => p.due_date.Day == DateTime.Today.Day && p.due_date.Month == DateTime.Today.Month && p.due_date.Year == DateTime.Today.Year).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Start Date", typeof(string));
            dt.Columns.Add("Comments", typeof(string));

            for (int i = 0; i < taskList.Count(); i++)
            {
                dt.Rows.Add(taskList[i].name, taskList[i].start_date.ToShortDateString(), taskList[i].comments);

            }


            TasksForTodayGridView.DataSource = dt;
            TasksForTodayGridView.DataBind();
            
        }


        private void loadUnfinishedTasks()
        {
            List<Task> taskList = new List<Task>();
            taskList = entity.Tasks.Where(p => p.completion_date == null).OrderBy(p=>p.due_date).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Start Date", typeof(string));
            dt.Columns.Add("Due Date", typeof(string));
            dt.Columns.Add("Comments", typeof(string));

            for (int i = 0; i < taskList.Count(); i++)
            {
                if (taskList[i].due_date.Date == DateTime.Today)
                {
                    dt.Rows.Add(taskList[i].name, taskList[i].start_date.ToShortDateString(), taskList[i].due_date.ToShortDateString(), taskList[i].comments);
                }
                else
                {
                    dt.Rows.Add(taskList[i].name, taskList[i].start_date.ToShortDateString(), "", taskList[i].comments);

                }
            }


            UnfinishedTasksGridView.DataSource = dt;
            UnfinishedTasksGridView.DataBind();

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Task task = new Task();

            task.name = txtName.Text;
            task.comments = txtAreaComments.Text;
            
            task.start_date = new DateTime(int.Parse(txtStartDate.Text.Substring(6, 4)), int.Parse(txtStartDate.Text.Substring(3, 2)), int.Parse(txtStartDate.Text.Substring(0, 2)));
             task.due_date= new DateTime(int.Parse(txtDueDate.Text.Substring(6,4)),int.Parse(txtDueDate.Text.Substring(3,2)),int.Parse(txtDueDate.Text.Substring(0,2)));
             if (txtCompletionDate.Text != "")
             {
                 task.completion_date = new DateTime(int.Parse(txtCompletionDate.Text.Substring(6, 4)), int.Parse(txtCompletionDate.Text.Substring(3, 2)), int.Parse(txtCompletionDate.Text.Substring(0, 2)));
             }

            entity.Tasks.AddObject(task);

            entity.SaveChanges();

            loadTasksForToday();
            loadUnfinishedTasks();

           
            
        }


    }
}
