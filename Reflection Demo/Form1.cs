using System.Reflection;
using System.Windows.Forms;
using System;
namespace Reflection_Demo
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         string TypeName = txtbox.Text;
         Type T = Type.GetType(TypeName);


         MethodInfo[] methods = T.GetMethods();
         foreach (MethodInfo method in methods)
         {
            listBox1.Items.Add(method.ReturnType.Name + " " + method.Name);
         }

         PropertyInfo[] properties = T.GetProperties();
         foreach (PropertyInfo property in properties)
         {
            listBox2.Items.Add(property.PropertyType.Name + " " + property.Name);
         }
         ConstructorInfo[] constructors = T.GetConstructors();
         foreach (ConstructorInfo constructor in constructors)
         {
            listBox3.Items.Add(constructor.ToString);
         }


      }
   }
   public class ProgramTest
   {
      public void Main()
      {

      }
   }

}