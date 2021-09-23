using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_Windows.Kelas
{
    class MainControllClass
    {
        public static void showControl (System.Windows.Forms.Control control, System.Windows.Forms.Control Content)
        {
            Content.Controls.Clear();

            control.Show();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            Content.Controls.Add(control);
        }

        public static bool IsValidateIP(string Address)
        {
            //Match pattern for IP address    
            string Pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
            //Regular Expression object    
            Regex check = new Regex(Pattern);

            //check to make sure an ip address was provided    
            if (string.IsNullOrEmpty(Address))
            {
                //returns false if IP is not provided    
                return false;
            }
            else
            {
                //Matching the pattern    
                return check.IsMatch(Address, 0);
            }
        }

        public static bool isEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            return match.Success;
        }

        public static bool isUrl(string url)
        {
            Regex regex = new Regex(@"^(http|http(s)?://)?([\w-]+\.)+[\w-]+[.com|.in|.org]+(\[\?%&=]*)?");
            Match match = regex.Match(url);
            return match.Success;
        }

        public static bool isNumber(string number)
        {
            Regex regex = new Regex(@"((\+628[/]*)?(\d[/]*){8}\d)");
            Match match = regex.Match(number);
            return match.Success;
        }
    }
}
