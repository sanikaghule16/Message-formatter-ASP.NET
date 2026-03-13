using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Message_formatter
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text.Trim();
            string message = TextBox2.Text.Trim();
            string formattedMessage = message;
            // Check formatting options
            if (Bold.Checked)
                formattedMessage = "<b>" + formattedMessage + "</b>";
            if (Italic.Checked)
                formattedMessage = "<i>" + formattedMessage + "</i>";
            if (UnderLine.Checked)
                formattedMessage = "<u>" + formattedMessage + "</u>";
            // Apply color
            Color textColor = GetSelectedColor();
            string colorCode = ColorTranslator.ToHtml(textColor);
            formattedMessage = $"<font color='{colorCode}'>{formattedMessage}</font>";
            // Display formatted message
            Label5.Text = $"{name}: {formattedMessage}";
        }
        private Color GetSelectedColor()
        {
            // Get selected color from radio buttons
            if (Red.Checked)
                return Color.Red;
            else if (Green.Checked)
                return Color.Green;
            else if (Blue.Checked)
                return Color.Blue;
            else
                return Color.Black; // Default color
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Clear text boxes and label
            TextBox1.Text = "";
            TextBox2.Text = "";
            Label5.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // Close the web page
            Response.Redirect("about:blank");
        }
    }
}
