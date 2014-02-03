using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Versaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            if (Button.Text == "Bestäm antalet versaler")
            {
                TextArea.Enabled = false;
                
                var input = TextArea.Text;
                int C = Model.TextAnalyzer.GetNumberOfC(input);
                Label.Text += Model.TextAnalyzer.GetNumberOfC(input);
                Button.Text = "Rensa";
                Label.Text = "Texten innehåller"  +" "+ C +" "+ "versaler";
            }
            else {

                TextArea.Enabled = true;
                Button.Text = "Bestäm antalet versaler";

            
            }
            


        }
    }
}