using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
/// <summary>
/// Tasarımcı desteği için gerekli metot - bu metodun 
///içeriğini kod düzenleyici ile değiştirmeyin.
/// </summary>
namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

       
        private void InitializeComponent()
        {

            this.listBoxLeft = new System.Windows.Forms.ListBox();
            this.listBoxMid = new System.Windows.Forms.ListBox();
            this.listBoxRight = new System.Windows.Forms.ListBox();

            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            //listBoxLeft
            //
            this.listBoxLeft.Location = new System.Drawing.Point(50, 50);
            this.listBoxLeft.Size = new System.Drawing.Size(100, 200);
            //
            //listBoxMid
            //
            this.listBoxMid.Location = new System.Drawing.Point(200, 50);
            this.listBoxMid.Size = new System.Drawing.Size(100, 200);
            this.listBoxMid.Items.Add("RED");
            this.listBoxMid.Items.Add("APPLE");
            this.listBoxMid.Items.Add("BLUE");
            this.listBoxMid.Items.Add("PEACH");
            this.listBoxMid.Items.Add("BLACK");
            this.listBoxMid.Items.Add("BANANA");
            this.listBoxMid.Items.Add("YELLOW");
            this.listBoxMid.Items.Add("CHERRY");
            this.listBoxMid.Items.Add("PURPLE");
            this.listBoxMid.Items.Add("MANGO");
            
            //
            //listBoxRight
            //
            this.listBoxRight.Location = new System.Drawing.Point(350, 50);
            this.listBoxRight.Size = new System.Drawing.Size(100, 200);
            //
            //buttonLeft
            //
            this.buttonLeft.Location = new System.Drawing.Point(155, 130);
            this.buttonLeft.Size = new System.Drawing.Size(41, 41);
            this.buttonLeft.Text = "< L >";
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            //
            //buttonRight
            //
            this.buttonRight.Location = new System.Drawing.Point(305, 130);
            this.buttonRight.Size = new System.Drawing.Size(41, 41);
            this.buttonRight.Text = "< R >";
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            //
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            //buttons and listboxes adds to form
            this.Controls.Add(this.listBoxLeft);
            this.Controls.Add(this.listBoxMid);
            this.Controls.Add(this.listBoxRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);

        }

        #endregion
        //Button and Listbox type variables
        private System.Windows.Forms.ListBox listBoxLeft;
        private System.Windows.Forms.ListBox listBoxMid;
        private System.Windows.Forms.ListBox listBoxRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;

    }
}

