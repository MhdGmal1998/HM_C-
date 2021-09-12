using System.Windows.Forms;
using System.Drawing;
namespace AddEmpolyeeForm
{
    partial class Form1:Form
    {
        // The required Buttons for desinger 
        private Button BtnAddEmpolyee;
        private Button BtnClear;

        // The required TextBox 
        private TextBox TxtEmpolyeeId;
        private TextBox TxtEmpolyeeName;
        private TextBox TxtEmpolyeeSalary;

        // The required ComboBox
        private ComboBox CmbEmpolyeeType;

        // The required Labels
        private Label lblHeader;
        private Label lblEmpolyeeCount;
        private Label lblEmpolyeeSalary;
        private Label lblEmpolyeeId;
        private Label lblEpolyeeName;
        private Label lblEpolyeeType;
        private Label lblEmpolyeeSalariesSum;
        private Label lblEmpolyeeCountHint;
        private Label lblEmpolyeeSalariesSumnHint;
        // ----------------------------------------//
        private System.ComponentModel.IContainer components = null;
    
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

       
        private void InitializeComponent()
        {
            
            SuspendLayout();
            /*The Required Button For Desinger */
            // 
            // BtnAddEmpolyee
            // 
            BtnAddEmpolyee = new Button();
            BtnAddEmpolyee.Location = new Point(405, 275);
            BtnAddEmpolyee.Size = new Size(100, 50);
            BtnAddEmpolyee.Text = "Add";
            BtnAddEmpolyee.Click += AddEmpolyeeClick;
            Controls.Add(BtnAddEmpolyee);
            // 
            // BtnClear
            // 
            BtnClear = new Button();
            BtnClear.Location = new Point(500, 275);
            BtnClear.Size = new Size(100, 50);
            BtnClear.Text = "Clear";
            BtnClear.Click+=ClearBtnClick;
            Controls.Add(BtnClear);

            /*The Required TextBox For Designer*/
            // 
            // TxtEmpolyeeId
            // 

            TxtEmpolyeeId = new TextBox();
            TxtEmpolyeeId.Location = new Point(200, 80);
            TxtEmpolyeeId.Size = new Size(200, 37);
            Controls.Add(TxtEmpolyeeId);

            // 
            // TxtEmpolyeeName
            // 
            TxtEmpolyeeName = new TextBox();
            TxtEmpolyeeName.Location = new Point(200, 130);
            TxtEmpolyeeName.Size = new Size(200, 37);
            Controls.Add(TxtEmpolyeeName);

            /*The Required Combox For Label*/
            // 
            // CmbEmpolyeeType
            // 
            CmbEmpolyeeType = new ComboBox();
            CmbEmpolyeeType.Location = new Point(200, 180);
            CmbEmpolyeeType.Size = new Size(200, 37);
            Controls.Add(CmbEmpolyeeType);

            // 
            // TxtEmpolyeeSalary
            // 
            TxtEmpolyeeSalary = new TextBox();
            TxtEmpolyeeSalary.Location = new Point(200, 230);
            TxtEmpolyeeSalary.Size = new Size(200, 37);
            Controls.Add(TxtEmpolyeeSalary);





            /*The Required Label */
            //
            // lblHeader
            //
            lblHeader = new Label();
            lblHeader.Text = "Empolyee Application ";
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(Width/2,10);
            Controls.Add(lblHeader);

            // 
            // lblEmpolyeeId
            // 
            lblEmpolyeeId = new Label();
            lblEmpolyeeId.AutoSize = true;
            lblEmpolyeeId.Location = new System.Drawing.Point(10, 80);
            lblEmpolyeeId.Size = new System.Drawing.Size(118, 29);
            lblEmpolyeeId.Text = "Empolyee Id";
            Controls.Add(lblEmpolyeeId);

            // 
            // lblEpolyeeName
            // 
            lblEpolyeeName = new Label();
            lblEpolyeeName.Location = new Point(10, 130);
            lblEpolyeeName.Size = new Size(168, 23);
            lblEpolyeeName.Text = "Empolyee Name";
            Controls.Add(lblEpolyeeName);

            // 
            // lblEpolyeeType
            // 
            lblEpolyeeType = new Label();
            lblEpolyeeType.Location = new System.Drawing.Point(10, 180);
            lblEpolyeeType.Size = new System.Drawing.Size(100, 23);
            lblEpolyeeType.Text = "Empolyee Type";
            lblEpolyeeType.AutoSize = true;
            Controls.Add(lblEpolyeeType);

            // lblEmpolyeeSalary
            lblEmpolyeeSalary = new Label();
            lblEmpolyeeSalary.AutoSize = true;
            lblEmpolyeeSalary.Text = "Empolyee Salary";
            lblEmpolyeeSalary.Location = new Point(10, 230);
            Controls.Add(lblEmpolyeeSalary);

            // 
            // lblEmpolyeeCount
            // 
            lblEmpolyeeCount = new Label();
            lblEmpolyeeCount.Location = new Point(200, 300);
            lblEmpolyeeCount.Size = new Size(100, 23);
            lblEmpolyeeCount.Text = "0";
            Controls.Add(lblEmpolyeeCount);

            // 
            // lblEmpolyeeSalariesSum
            // 
            lblEmpolyeeSalariesSum = new Label();
            lblEmpolyeeSalariesSum.Location = new Point(200, 350);
            lblEmpolyeeSalariesSum.AutoSize = true;
            lblEmpolyeeSalariesSum.Text = "0.00";
            Controls.Add(lblEmpolyeeSalariesSum);

            // lblEmpolyeeCountHint
            lblEmpolyeeCountHint = new Label();
            lblEmpolyeeCountHint.Location = new Point(10,300);
            lblEmpolyeeCountHint.Text = "Empolyee Count :";
            lblEmpolyeeCountHint.AutoSize = true;
            Controls.Add(lblEmpolyeeCountHint);

            // lblEmpolyeeSalariesSumnHint
            lblEmpolyeeSalariesSumnHint = new Label();
            lblEmpolyeeSalariesSumnHint.Text = "Empolyee Salaries :";
            lblEmpolyeeSalariesSumnHint.Location = new Point(10, 350);
            lblEmpolyeeSalariesSumnHint.AutoSize = true;
            Controls.Add(lblEmpolyeeSalariesSumnHint);
            //
            // Form1
            // 
          
            Font = new Font("Adobe Arabic", 20F, FontStyle.Bold);
            Text = "Empolyee Application";
            Size = new Size(620,450);
            ResumeLayout(false);
            PerformLayout();
            AutoSize = true;
            
        }

        #endregion
    }
}
