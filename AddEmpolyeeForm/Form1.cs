using AddEmpolyeeAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddEmpolyeeForm
{
    public enum EmpolyeeType
    {
        Teacher,
        HeadMaster,
        HeadOfDepartment
    }
    public partial class Form1 : Form
    {
        List<IEmpolyee> empolyee = new List<IEmpolyee>();
        public Form1()
        {
            
            InitializeComponent();
            CmbEmpolyeeType.DataSource = Enum.GetValues(typeof(EmpolyeeType));

        }

        private void ClearEmpolyeeClick(Object sender,EventArgs arg)
        {

        }
        private void AddEmpolyeeClick(Object sender,EventArgs arg)
        {
            //if(CmbEmpolyeeType.Text.ToString()=="Teacher")
            //{
            //    IEmpolyee teacher = new Teacher
            //    {
            //        Id = Convert.ToInt32(TxtEmpolyeeId.Text),
            //        Name = TxtEmpolyeeName.Text,
            //        Salary = Convert.ToDecimal(TxtEmpolyeeSalary.Text)+(Convert.ToDecimal(TxtEmpolyeeSalary.Text)*0.05m)
            //    };
            //    empolyee.Add(teacher);
            //}
            //else if(CmbEmpolyeeType.Text.ToString() == "HeadMaster")
            //{
            //    IEmpolyee headmaster = new HeadMaster
            //    {
            //        Id = Convert.ToInt32(TxtEmpolyeeId.Text),
            //        Name = TxtEmpolyeeName.Text,
            //        Salary = Convert.ToDecimal(TxtEmpolyeeSalary.Text) + (Convert.ToDecimal(TxtEmpolyeeSalary.Text) * 0.10m)
            //    };
            //    empolyee.Add(headmaster);
            //}
            //else
            //{
            //    IEmpolyee headofdepartment = new HeadOfDepartment
            //    {
            //        Id = Convert.ToInt32(TxtEmpolyeeId.Text),
            //        Name = TxtEmpolyeeName.Text,
            //        Salary = Convert.ToDecimal(TxtEmpolyeeSalary.Text) + (Convert.ToDecimal(TxtEmpolyeeSalary.Text) * 0.15m)
            //    };
            //    empolyee.Add(headofdepartment);
            //}

            //lblEmpolyeeCount.Text = empolyee.Count.ToString();
            //decimal SumEmpolyeeSalaries = 0;
            //foreach (IEmpolyee ei in empolyee)
            //{
            //    SumEmpolyeeSalaries += ei.Salary;
            //}
            //lblEmpolyeeSalariesSum.Text = SumEmpolyeeSalaries.ToString();

            if(CmbEmpolyeeType.Text.Equals(EmpolyeeType.Teacher.ToString()))
            {
                IEmpolyee teacher = EmployeeFactory.GetEmpolyeeInstance(EmpolyeeType.Teacher, Convert.ToInt32(TxtEmpolyeeId.Text), TxtEmpolyeeName.Text, Convert.ToDecimal(TxtEmpolyeeSalary.Text));
                empolyee.Add(teacher);
            }
            else if(CmbEmpolyeeType.Text.Equals(EmpolyeeType.HeadOfDepartment.ToString()))
            {
                IEmpolyee headofdepartment = EmployeeFactory.GetEmpolyeeInstance(EmpolyeeType.HeadOfDepartment, Convert.ToInt32(TxtEmpolyeeId.Text), TxtEmpolyeeName.Text, Convert.ToDecimal(TxtEmpolyeeSalary.Text));
                empolyee.Add(headofdepartment);
            }
            else
            {
                IEmpolyee headmaster = EmployeeFactory.GetEmpolyeeInstance(EmpolyeeType.HeadMaster, Convert.ToInt32(TxtEmpolyeeId.Text), TxtEmpolyeeName.Text, Convert.ToDecimal(TxtEmpolyeeSalary.Text));
                empolyee.Add(headmaster);
            }
           
            lblEmpolyeeCount.Text = empolyee.Count.ToString();
            lblEmpolyeeSalariesSum.Text = empolyee.Sum(e => e.Salary).ToString();
        //    MessageBox.Show(CmbEmpolyeeType.Text);
        }
    }

    public class Teacher : EmpolyeeBase
    {
         public override decimal Salary
        {
            get
            {
                return (base.Salary + (base.Salary*0.03m));
            }
        }
    }

    public class HeadMaster : EmpolyeeBase
    {
        public override decimal Salary
        {
            get
            {
                return (base.Salary + (base.Salary * 0.10m));
            }
        }
    }
    public class HeadOfDepartment : EmpolyeeBase
    {
        public override decimal Salary
        {
            get
            {
                return (base.Salary + (base.Salary * 0.15m));
            }
        }
    }

    public static class EmployeeFactory
    {
        public static IEmpolyee GetEmpolyeeInstance(EmpolyeeType empolyeetype, int id, string name,decimal salary)
        {
            IEmpolyee empolyee = null;
            switch(empolyeetype)
            {
                case EmpolyeeType.Teacher:
                    empolyee = new Teacher { Id = id, Name = name, Salary = salary };
                    break;
                case EmpolyeeType.HeadOfDepartment:
                    empolyee = new HeadOfDepartment { Id = id, Name = name, Salary = salary };
                    break;
                case EmpolyeeType.HeadMaster:
                    empolyee = new HeadMaster { Id = id, Name = name, Salary = salary };
                    break;
                default:
                    break;
            }
            return empolyee;
        }
    }
}
