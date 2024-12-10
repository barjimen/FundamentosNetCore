namespace FundamentosNetCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Text = "Hola";
            this.SuspendLayout();
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(79, 117);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(282, 253);
            Controls.Add(button1);
            Name = "Form1";
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
