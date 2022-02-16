using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XMLProject
{
    public partial class form : Form
    {
        XmlDocument xmlDoc;
        List<Employee> Employees = new List<Employee>();
        int current;


        public form()
        {
            InitializeComponent();
            xmlDoc = new XmlDocument();
            xmlDoc.Load("product.xml");
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/employee");
            foreach (XmlNode node in nodeList)
            {
                string name = node.SelectSingleNode("employee_name").InnerText;
                string phone = node.SelectSingleNode("employee_Phone").InnerText;
                string add = node.SelectSingleNode("employee_address").InnerText;
                string email = node.SelectSingleNode("employee_Email").InnerText;
                string id = node.SelectSingleNode("@id").InnerText;

                Employees.Add(new Employee(Int32.Parse(id), name, phone, add, email));
                current = 0;

            }
            nameText.Text = Employees[0].Name;
            phoneText.Text = Employees[0].Phone;
            addressText.Text = Employees[0].Address;
            emailText.Text = Employees[0].Email;




        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {

            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table");

            XmlNode root = xmlDoc.DocumentElement;

            //Create a new node.
            XmlElement employee_name = xmlDoc.CreateElement("employee_name");
            XmlElement employee_address = xmlDoc.CreateElement("employee_address");
            XmlElement employee_email = xmlDoc.CreateElement("employee_Email");

            XmlElement employee_phone = xmlDoc.CreateElement("employee_Phone");

            XmlElement employee = xmlDoc.CreateElement("employee");
            employee_name.InnerText = nameText.Text;
            employee_address.InnerText = addressText.Text;
            employee_email.InnerText = emailText.Text;

            employee_phone.InnerText = phoneText.Text;
            employee.SetAttribute("id", Employees.Count.ToString());



            //Add the node to the document.
            root.AppendChild(employee);
            employee.AppendChild(employee_name);
            employee.AppendChild(employee_email);
            employee.AppendChild(employee_address);
            employee.AppendChild(employee_phone);

            Employees.Add(new Employee(Employees.Count, nameText.Text, phoneText.Text, addressText.Text, emailText.Text));



            Console.WriteLine("Display the modified XML...");
            xmlDoc.Save("product.xml");
            current = Employees.Count-1;

            nameText.Text = Employees[current].Name;
            phoneText.Text = Employees[current].Phone;
            addressText.Text = Employees[current].Address;
            emailText.Text = Employees[current].Email;

        }

        private void next_Click(object sender, EventArgs e)
        {
            current = (current + 1) % Employees.Count;

            nameText.Text = Employees[current].Name;
            phoneText.Text = Employees[current].Phone;
            addressText.Text = Employees[current].Address;
            emailText.Text = Employees[current].Email;


        }

        private void prev_Click(object sender, EventArgs e)
        {
            if (current == 0)
            {
                current = Employees.Count;
            }
            current = (current - 1) % Employees.Count;

            nameText.Text = Employees[current].Name;
            phoneText.Text = Employees[current].Phone;
            addressText.Text = Employees[current].Address;
            emailText.Text = Employees[current].Email;
        }

        private void update_Click(object sender, EventArgs e)

        {
            Employees[current].Name = nameText.Text;
            Employees[current].Phone = phoneText.Text;
            Employees[current].Address = address.Text;
            Employees[current].Email = emailText.Text;
            int indexXMl = current + 1;

            string s = "/Table/employee" + "[" + indexXMl + "]";
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes(s);

            nodeList[0].SelectSingleNode("employee_name").InnerText = nameText.Text;
            nodeList[0].SelectSingleNode("employee_Phone").InnerText = Employees[current].Phone;
            nodeList[0].SelectSingleNode("employee_address").InnerText = Employees[current].Address;
            nodeList[0].SelectSingleNode("employee_Email").InnerText = Employees[current].Email;
            xmlDoc.Save("product.xml");


        }

        private void delete_Click(object sender, EventArgs e)
        {
            int indexXMl = current + 1;

            string s = "/Table/employee" + "[" + indexXMl + "]";

            var node = xmlDoc.SelectSingleNode(s);
            foreach (XmlNode child in node.ChildNodes)
            {
                node.AppendChild(child);
            }
            node.ParentNode.RemoveChild(node);

            Employees.RemoveAt(current);
            current = 0;
            nameText.Text = Employees[current].Name;
            phoneText.Text = Employees[current].Phone;
            addressText.Text = Employees[current].Address;
            emailText.Text = Employees[current].Email;
            xmlDoc.Save("product.xml");


            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/employee");
            for (int i = 0; i < Employees.Count; i++)
            {
                nodeList[i].Attributes[0].Value = i.ToString();
            }
            xmlDoc.Save("product.xml");



        }

        private void SearchByname_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                if (Employees[i].Name == nameText.Text)
                {
                    //Employees[current].Name = nameText.Text;
                    phoneText.Text = Employees[i].Phone;
                    addressText.Text = Employees[i].Address;
                    emailText.Text = Employees[i].Email;

                }

            }
        }

        string GetPathToDefaultBrowser()
        {
            const string currentUserSubKey =
            @"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice";
            using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(currentUserSubKey, false))
            {
                string progId = (userChoiceKey.GetValue("ProgId").ToString());
                using (RegistryKey kp =
                       Registry.ClassesRoot.OpenSubKey(progId + @"\shell\open\command", false))
                {
                    // Get default value and convert to EXE path.
                    // It's stored as:
                    //    "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe" -- "%1"
                    // So we want the first quoted string only
                    string rawValue = (string)kp.GetValue("");
                    Regex reg = new Regex("(?<=\").*?(?=\")");
                    Match m = reg.Match(rawValue);
                    return m.Success ? m.Value : "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {// This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // or: Directory.GetCurrentDirectory() gives the same result

            // This will get the current PROJECT bin directory (ie ../bin/)
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            MessageBox.Show(projectDirectory);

            string fullpath = projectDirectory + @"\Debug\net5.0-windows\product.xml";
              Uri uri = new System.Uri(fullpath);
            string converted = uri.AbsoluteUri;
            string browserPath = GetPathToDefaultBrowser();
            Process.Start(browserPath, converted);
        }
    }
}
