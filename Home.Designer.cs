
namespace Новая_курсовая
{
    partial class Home
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.by_SenseDelivery = new System.Windows.Forms.Button();
            this.by_SenseOne = new System.Windows.Forms.Button();
            this.By_KEFFIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // by_SenseDelivery
            // 
            this.by_SenseDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.by_SenseDelivery.Location = new System.Drawing.Point(11, 72);
            this.by_SenseDelivery.Margin = new System.Windows.Forms.Padding(2);
            this.by_SenseDelivery.Name = "by_SenseDelivery";
            this.by_SenseDelivery.Size = new System.Drawing.Size(249, 43);
            this.by_SenseDelivery.TabIndex = 7;
            this.by_SenseDelivery.Text = "Закрыть";
            this.by_SenseDelivery.UseVisualStyleBackColor = true;
            this.by_SenseDelivery.Click += new System.EventHandler(this.button4_Click);
            // 
            // by_SenseOne
            // 
            this.by_SenseOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.by_SenseOne.Location = new System.Drawing.Point(138, 11);
            this.by_SenseOne.Margin = new System.Windows.Forms.Padding(2);
            this.by_SenseOne.Name = "by_SenseOne";
            this.by_SenseOne.Size = new System.Drawing.Size(122, 57);
            this.by_SenseOne.TabIndex = 5;
            this.by_SenseOne.Text = "Сотрудники";
            this.by_SenseOne.UseVisualStyleBackColor = true;
            this.by_SenseOne.Click += new System.EventHandler(this.button2_Click);
            // 
            // By_KEFFIR
            // 
            this.By_KEFFIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.By_KEFFIR.Location = new System.Drawing.Point(11, 11);
            this.By_KEFFIR.Margin = new System.Windows.Forms.Padding(2);
            this.By_KEFFIR.Name = "By_KEFFIR";
            this.By_KEFFIR.Size = new System.Drawing.Size(122, 57);
            this.By_KEFFIR.TabIndex = 4;
            this.By_KEFFIR.Text = "Меню";
            this.By_KEFFIR.UseVisualStyleBackColor = true;
            this.By_KEFFIR.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 130);
            this.Controls.Add(this.by_SenseDelivery);
            this.Controls.Add(this.by_SenseOne);
            this.Controls.Add(this.By_KEFFIR);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button by_SenseDelivery;
        private System.Windows.Forms.Button by_SenseOne;
        private System.Windows.Forms.Button By_KEFFIR;
    }
}

