
namespace GATO_NA11
{
    partial class Gato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblScoreX = new System.Windows.Forms.Label();
            this.lblScoreY = new System.Windows.Forms.Label();
            this.lblQtyX = new System.Windows.Forms.Label();
            this.lblQtyY = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblShiftXorY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.Location = new System.Drawing.Point(53, 657);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(211, 60);
            this.BtnIniciar.TabIndex = 0;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            this.BtnIniciar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Gato_KeyPress);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Location = new System.Drawing.Point(289, 657);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(211, 60);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "nuevo juego";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            this.BtnNuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Gato_KeyPress);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(682, 707);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(108, 28);
            this.BtnActualizar.TabIndex = 2;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            this.BtnActualizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Gato_KeyPress);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPuntaje.Location = new System.Drawing.Point(687, 563);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(94, 32);
            this.lblPuntaje.TabIndex = 3;
            this.lblPuntaje.Text = "Score";
            // 
            // lblScoreX
            // 
            this.lblScoreX.AutoSize = true;
            this.lblScoreX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScoreX.Location = new System.Drawing.Point(646, 606);
            this.lblScoreX.Name = "lblScoreX";
            this.lblScoreX.Size = new System.Drawing.Size(35, 32);
            this.lblScoreX.TabIndex = 4;
            this.lblScoreX.Text = "X";
            // 
            // lblScoreY
            // 
            this.lblScoreY.AutoSize = true;
            this.lblScoreY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreY.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScoreY.Location = new System.Drawing.Point(646, 658);
            this.lblScoreY.Name = "lblScoreY";
            this.lblScoreY.Size = new System.Drawing.Size(38, 32);
            this.lblScoreY.TabIndex = 5;
            this.lblScoreY.Text = "O";
            // 
            // lblQtyX
            // 
            this.lblQtyX.AutoSize = true;
            this.lblQtyX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQtyX.Location = new System.Drawing.Point(793, 606);
            this.lblQtyX.Name = "lblQtyX";
            this.lblQtyX.Size = new System.Drawing.Size(32, 32);
            this.lblQtyX.TabIndex = 6;
            this.lblQtyX.Text = "0";
            // 
            // lblQtyY
            // 
            this.lblQtyY.AutoSize = true;
            this.lblQtyY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyY.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQtyY.Location = new System.Drawing.Point(793, 658);
            this.lblQtyY.Name = "lblQtyY";
            this.lblQtyY.Size = new System.Drawing.Size(32, 32);
            this.lblQtyY.TabIndex = 7;
            this.lblQtyY.Text = "0";
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShift.Location = new System.Drawing.Point(149, 552);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(126, 47);
            this.lblShift.TabIndex = 8;
            this.lblShift.Text = "Turno: ";
            // 
            // lblShiftXorY
            // 
            this.lblShiftXorY.AutoSize = true;
            this.lblShiftXorY.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftXorY.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShiftXorY.Location = new System.Drawing.Point(281, 552);
            this.lblShiftXorY.Name = "lblShiftXorY";
            this.lblShiftXorY.Size = new System.Drawing.Size(124, 47);
            this.lblShiftXorY.TabIndex = 9;
            this.lblShiftXorY.Text = "X or O";
            // 
            // Gato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(914, 747);
            this.Controls.Add(this.lblShiftXorY);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.lblQtyY);
            this.Controls.Add(this.lblQtyX);
            this.Controls.Add(this.lblScoreY);
            this.Controls.Add(this.lblScoreX);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnIniciar);
            this.MaximizeBox = false;
            this.Name = "Gato";
            this.Text = "GATO NA11";
            this.Load += new System.EventHandler(this.Gato_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Gato_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblScoreX;
        private System.Windows.Forms.Label lblScoreY;
        private System.Windows.Forms.Label lblQtyX;
        private System.Windows.Forms.Label lblQtyY;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label lblShiftXorY;
    }
}

