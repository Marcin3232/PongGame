namespace PongGame
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_LOSE = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.pB_Left = new System.Windows.Forms.PictureBox();
            this.pB_Enemy = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.pointLeft = new System.Windows.Forms.Label();
            this.pointRight = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label_LOSE);
            this.panel1.Controls.Add(this.label_start);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ball);
            this.panel1.Controls.Add(this.pB_Left);
            this.panel1.Controls.Add(this.pB_Enemy);
            this.panel1.Location = new System.Drawing.Point(41, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 315);
            this.panel1.TabIndex = 0;
            // 
            // label_LOSE
            // 
            this.label_LOSE.AutoSize = true;
            this.label_LOSE.Font = new System.Drawing.Font("Monotxt_IV25", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_LOSE.ForeColor = System.Drawing.Color.White;
            this.label_LOSE.Location = new System.Drawing.Point(26, 260);
            this.label_LOSE.Name = "label_LOSE";
            this.label_LOSE.Size = new System.Drawing.Size(653, 36);
            this.label_LOSE.TabIndex = 5;
            this.label_LOSE.Text = "if you want again press SPACE";
            this.label_LOSE.Visible = false;
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.BackColor = System.Drawing.Color.Transparent;
            this.label_start.Font = new System.Drawing.Font("Monotxt_IV25", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_start.ForeColor = System.Drawing.Color.White;
            this.label_start.Location = new System.Drawing.Point(126, 91);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(496, 92);
            this.label_start.TabIndex = 4;
            this.label_start.Text = "If you want star \r\ngame press SPACE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotxt_IV25", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(250, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // ball
            // 
            this.ball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ball.BackgroundImage")));
            this.ball.Location = new System.Drawing.Point(337, 128);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(14, 14);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // pB_Left
            // 
            this.pB_Left.BackColor = System.Drawing.Color.Snow;
            this.pB_Left.Location = new System.Drawing.Point(3, 102);
            this.pB_Left.Name = "pB_Left";
            this.pB_Left.Size = new System.Drawing.Size(10, 70);
            this.pB_Left.TabIndex = 0;
            this.pB_Left.TabStop = false;
            // 
            // pB_Enemy
            // 
            this.pB_Enemy.BackColor = System.Drawing.Color.Snow;
            this.pB_Enemy.Location = new System.Drawing.Point(679, 102);
            this.pB_Enemy.Name = "pB_Enemy";
            this.pB_Enemy.Size = new System.Drawing.Size(10, 70);
            this.pB_Enemy.TabIndex = 1;
            this.pB_Enemy.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Monotxt_IV25", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(270, -2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(311, 53);
            this.title.TabIndex = 2;
            this.title.Text = "PONG Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotxt_IV25", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(272, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time: 00:00";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Monotxt_IV25", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score.Location = new System.Drawing.Point(342, 416);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(137, 40);
            this.score.TabIndex = 4;
            this.score.Text = "Score";
            // 
            // pointLeft
            // 
            this.pointLeft.AutoSize = true;
            this.pointLeft.Font = new System.Drawing.Font("Monotxt_IV25", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointLeft.Location = new System.Drawing.Point(34, 416);
            this.pointLeft.Name = "pointLeft";
            this.pointLeft.Size = new System.Drawing.Size(65, 40);
            this.pointLeft.TabIndex = 5;
            this.pointLeft.Text = "00";
            // 
            // pointRight
            // 
            this.pointRight.AutoSize = true;
            this.pointRight.Font = new System.Drawing.Font("Monotxt_IV25", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointRight.Location = new System.Drawing.Point(668, 412);
            this.pointRight.Name = "pointRight";
            this.pointRight.Size = new System.Drawing.Size(65, 40);
            this.pointRight.TabIndex = 6;
            this.pointRight.Text = "00";
            this.pointRight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pointRight);
            this.Controls.Add(this.pointLeft);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Enemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pB_Left;
        private System.Windows.Forms.PictureBox pB_Enemy;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label pointLeft;
        private System.Windows.Forms.Label pointRight;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label_LOSE;
        private System.Windows.Forms.Timer timer3;
    }
}

