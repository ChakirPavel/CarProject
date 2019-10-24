using CarProject.Models;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace CarProject.CustomControllers
{
    public class Field : FlowLayoutPanel
    {
        private Label title;
        public TextBox textBoxProperty;
        public string NameOfProperty { get { return (prop.Name); } }

        private PropertyInfo prop;
        public string Title { get { return (prop.GetCustomAttributes(typeof(TitleField), true).First() as TitleField).title; } }

        public Field(PropertyInfo prop)
            : base()
        {
            this.prop = prop;

            AutoSize = true;
            title = new Label();
            title.Text = Title;
            title.AutoSize = true;
            title.Anchor = AnchorStyles.Left;
            title.TextAlign = ContentAlignment.TopLeft;

            textBoxProperty = new TextBox();

            Controls.Add(title);
            Controls.Add(textBoxProperty);
        }
    }
}
