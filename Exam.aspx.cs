using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Exam2014
{
    public partial class Exam : System.Web.UI.Page
    {
          protected void Page_Load(object sender, EventArgs e)
        {
            btnProcess.Enabled = false;
        }
        public string Search(string search)
        {
            StreamReader file = new StreamReader("C:\\Users\\evashen\\Desktop\\phone.txt");
            string name, code, period, type;
            string output = "";
            Boolean found = false;
            while (file.Peek() > -1)
            {
                name = file.ReadLine();
                code = file.ReadLine();
                type = file.ReadLine();
                period = file.ReadLine();

                if (code == search)
                {
                    found = true;
                    output += "name :" + name + "<br>";
                    output += "code :" + code + "<br>";
                    output += "phone type :" + type + "<br>";
                    output += "period :" + period + "<br>";
                }
            }
            file.Close();
            if (found == false)
            {
                output = "not found";
            }
            return output;
        }

        protected void btnValidate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Error", "alert('Name Cannot be blank');", true);
                return;
            }


            if (txtSurname.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Error", "alert('surname Cannot be blank');", true);
                return;
            }
            if (txtApps.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Error", "alert('number of apps Cannot be blank');", true);
                return;
            }
            if ((Convert.ToInt16(txtApps.Text) > 3) || (Convert.ToInt16(txtApps.Text) <= 0))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Error", "alert('number of apps range 1-3');", true);
                return;
            }
            if ((rad12.Checked == false) && (rad24.Checked == false) && (rad36.Checked == false))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Error", "alert('select contact period');", true);
                return;
            }
            if ((radiPhone.Checked == false) && (radNokia.Checked == false) && (radSamsung.Checked == false))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Error", "alert('select phone type');", true);
                return;
            }
            btnProcess.Enabled = true;
        }

        protected void btnProcess_Click(object sender, EventArgs e)
        {
            //declare variables
            string name, surname, phone = "";
            int apps;
            decimal type = 0, period = 0, sms = 0, data = 0, airtime = 0;
          
            //convert input data
            name = txtName.Text;
            surname = txtSurname.Text;
            apps = Convert.ToInt16(txtApps.Text);
            if(radiPhone.Checked)
            {
                type = Convert.ToDecimal(8500);
                phone = "iPhone 6";
            }
            if (radNokia.Checked)
            {
                type = Convert.ToDecimal(8300);
                phone = "Nokia Lumia 1520";
            }
            if (radSamsung.Checked)
            {
                type = Convert.ToDecimal(7800);
                phone = "Samsung Galaxy S6";
            }
            if(rad12.Checked)
            {
                period = 12;
            }
            if (rad24.Checked)
            {
                period = 24;
            }
            if (rad36.Checked)
            {
                period = 36;
            }

            if(chkSMS.Checked)
            {
                sms = Convert.ToDecimal(0.01);
            }
            else if (chkData.Checked)
            {
                data = Convert.ToDecimal(0.02);
            }
            else if (chkAirtime.Checked)
            {
                airtime = Convert.ToDecimal(0.015);
            }

            Phones obj = new Phones(name,surname,apps,airtime,data,sms,period,type);
            string code = name + obj.GenerateCode();
            lblGenCode.Text = code;
            lblMonthly.Text = obj.calcMonthlyPremium().ToString("R0.00");
            lblTotal.Text = obj.calcTotalPremium().ToString("R0.00");
            obj.SaveData(name,code,phone,period);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string search=txtSearch.Text;
            lblOutput.Text=Search(search);
       }
    }
}