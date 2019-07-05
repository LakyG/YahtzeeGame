using System.Windows.Forms;

namespace YahtzeeGame
{
    partial class Game
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
            this.pnlScores = new System.Windows.Forms.TableLayoutPanel();
            this.lblScores = new System.Windows.Forms.Label();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOnes = new System.Windows.Forms.Label();
            this.lblTwos = new System.Windows.Forms.Label();
            this.lblThrees = new System.Windows.Forms.Label();
            this.lblFours = new System.Windows.Forms.Label();
            this.lblFives = new System.Windows.Forms.Label();
            this.lblSixes = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lbl3kind = new System.Windows.Forms.Label();
            this.lbl4kind = new System.Windows.Forms.Label();
            this.lblFull = new System.Windows.Forms.Label();
            this.lblSm = new System.Windows.Forms.Label();
            this.lblLg = new System.Windows.Forms.Label();
            this.lblChance = new System.Windows.Forms.Label();
            this.lblYah = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl13 = new System.Windows.Forms.Label();
            this.lbl14 = new System.Windows.Forms.Label();
            this.lbl15 = new System.Windows.Forms.Label();
            this.lbl16 = new System.Windows.Forms.Label();
            this.lbl1subtot = new System.Windows.Forms.Label();
            this.lbl1Bon = new System.Windows.Forms.Label();
            this.lbl13K = new System.Windows.Forms.Label();
            this.lbl14K = new System.Windows.Forms.Label();
            this.lbl1Full = new System.Windows.Forms.Label();
            this.lbl1Sm = new System.Windows.Forms.Label();
            this.lbl1Lg = new System.Windows.Forms.Label();
            this.lbl1Chan = new System.Windows.Forms.Label();
            this.lbl1Yah = new System.Windows.Forms.Label();
            this.lbl1Tot = new System.Windows.Forms.Label();
            this.lbl21 = new System.Windows.Forms.Label();
            this.lbl22 = new System.Windows.Forms.Label();
            this.lbl23 = new System.Windows.Forms.Label();
            this.lbl24 = new System.Windows.Forms.Label();
            this.lbl25 = new System.Windows.Forms.Label();
            this.lbl26 = new System.Windows.Forms.Label();
            this.lbl2subtot = new System.Windows.Forms.Label();
            this.lbl2Bon = new System.Windows.Forms.Label();
            this.lbl23K = new System.Windows.Forms.Label();
            this.lbl24K = new System.Windows.Forms.Label();
            this.lbl2Full = new System.Windows.Forms.Label();
            this.lbl2Sm = new System.Windows.Forms.Label();
            this.lbl2Lg = new System.Windows.Forms.Label();
            this.lbl2Chan = new System.Windows.Forms.Label();
            this.lbl2Yah = new System.Windows.Forms.Label();
            this.lbl2Tot = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnKeepScore = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDice = new System.Windows.Forms.TableLayoutPanel();
            this.lblDie1 = new System.Windows.Forms.Label();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.lblDie3 = new System.Windows.Forms.Label();
            this.lblDie4 = new System.Windows.Forms.Label();
            this.lblDie5 = new System.Windows.Forms.Label();
            this.lblMsgs = new System.Windows.Forms.Label();
            this.pnlScores.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlDice.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScores
            // 
            this.pnlScores.ColumnCount = 3;
            this.pnlScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.36946F));
            this.pnlScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.31527F));
            this.pnlScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.31527F));
            this.pnlScores.Controls.Add(this.lblScores, 0, 0);
            this.pnlScores.Controls.Add(this.lblP1, 1, 0);
            this.pnlScores.Controls.Add(this.lblP2, 2, 0);
            this.pnlScores.Controls.Add(this.lblTotal, 0, 16);
            this.pnlScores.Controls.Add(this.lblOnes, 0, 1);
            this.pnlScores.Controls.Add(this.lblTwos, 0, 2);
            this.pnlScores.Controls.Add(this.lblThrees, 0, 3);
            this.pnlScores.Controls.Add(this.lblFours, 0, 4);
            this.pnlScores.Controls.Add(this.lblFives, 0, 5);
            this.pnlScores.Controls.Add(this.lblSixes, 0, 6);
            this.pnlScores.Controls.Add(this.lblSubTotal, 0, 7);
            this.pnlScores.Controls.Add(this.lblBonus, 0, 8);
            this.pnlScores.Controls.Add(this.lbl3kind, 0, 9);
            this.pnlScores.Controls.Add(this.lbl4kind, 0, 10);
            this.pnlScores.Controls.Add(this.lblFull, 0, 11);
            this.pnlScores.Controls.Add(this.lblSm, 0, 12);
            this.pnlScores.Controls.Add(this.lblLg, 0, 13);
            this.pnlScores.Controls.Add(this.lblChance, 0, 14);
            this.pnlScores.Controls.Add(this.lblYah, 0, 15);
            this.pnlScores.Controls.Add(this.lbl11, 1, 1);
            this.pnlScores.Controls.Add(this.lbl12, 1, 2);
            this.pnlScores.Controls.Add(this.lbl13, 1, 3);
            this.pnlScores.Controls.Add(this.lbl14, 1, 4);
            this.pnlScores.Controls.Add(this.lbl15, 1, 5);
            this.pnlScores.Controls.Add(this.lbl16, 1, 6);
            this.pnlScores.Controls.Add(this.lbl1subtot, 1, 7);
            this.pnlScores.Controls.Add(this.lbl1Bon, 1, 8);
            this.pnlScores.Controls.Add(this.lbl13K, 1, 9);
            this.pnlScores.Controls.Add(this.lbl14K, 1, 10);
            this.pnlScores.Controls.Add(this.lbl1Full, 1, 11);
            this.pnlScores.Controls.Add(this.lbl1Sm, 1, 12);
            this.pnlScores.Controls.Add(this.lbl1Lg, 1, 13);
            this.pnlScores.Controls.Add(this.lbl1Chan, 1, 14);
            this.pnlScores.Controls.Add(this.lbl1Yah, 1, 15);
            this.pnlScores.Controls.Add(this.lbl1Tot, 1, 16);
            this.pnlScores.Controls.Add(this.lbl21, 2, 1);
            this.pnlScores.Controls.Add(this.lbl22, 2, 2);
            this.pnlScores.Controls.Add(this.lbl23, 2, 3);
            this.pnlScores.Controls.Add(this.lbl24, 2, 4);
            this.pnlScores.Controls.Add(this.lbl25, 2, 5);
            this.pnlScores.Controls.Add(this.lbl26, 2, 6);
            this.pnlScores.Controls.Add(this.lbl2subtot, 2, 7);
            this.pnlScores.Controls.Add(this.lbl2Bon, 2, 8);
            this.pnlScores.Controls.Add(this.lbl23K, 2, 9);
            this.pnlScores.Controls.Add(this.lbl24K, 2, 10);
            this.pnlScores.Controls.Add(this.lbl2Full, 2, 11);
            this.pnlScores.Controls.Add(this.lbl2Sm, 2, 12);
            this.pnlScores.Controls.Add(this.lbl2Lg, 2, 13);
            this.pnlScores.Controls.Add(this.lbl2Chan, 2, 14);
            this.pnlScores.Controls.Add(this.lbl2Yah, 2, 15);
            this.pnlScores.Controls.Add(this.lbl2Tot, 2, 16);
            this.pnlScores.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlScores.Location = new System.Drawing.Point(0, 0);
            this.pnlScores.Name = "pnlScores";
            this.pnlScores.RowCount = 17;
            this.pnlScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.487084F));
            this.pnlScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.535054F));
            this.pnlScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.535054F));
            this.pnlScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.535054F));
            this.pnlScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.535054F));
            this.pnlScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.535054F));
            this.pnlScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.535054F));
            this.pnlScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.535054F));
            this.pnlScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.535054F));
            this.pnlScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.535054F));
            this.pnlScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.535054F));
            this.pnlScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.535054F));
            this.pnlScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.535054F));
            this.pnlScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.535054F));
            this.pnlScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.535054F));
            this.pnlScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.535054F));
            this.pnlScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.487084F));
            this.pnlScores.Size = new System.Drawing.Size(500, 561);
            this.pnlScores.TabIndex = 1;
            // 
            // lblScores
            // 
            this.lblScores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScores.AutoSize = true;
            this.lblScores.BackColor = System.Drawing.Color.SteelBlue;
            this.lblScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.Location = new System.Drawing.Point(0, 0);
            this.lblScores.Margin = new System.Windows.Forms.Padding(0);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(376, 47);
            this.lblScores.TabIndex = 0;
            this.lblScores.Text = "Scores";
            this.lblScores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblP1
            // 
            this.lblP1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblP1.AutoSize = true;
            this.lblP1.BackColor = System.Drawing.Color.SteelBlue;
            this.lblP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.Location = new System.Drawing.Point(376, 0);
            this.lblP1.Margin = new System.Windows.Forms.Padding(0);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(61, 47);
            this.lblP1.TabIndex = 1;
            this.lblP1.Text = "P1";
            this.lblP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblP2
            // 
            this.lblP2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblP2.AutoSize = true;
            this.lblP2.BackColor = System.Drawing.Color.SteelBlue;
            this.lblP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2.Location = new System.Drawing.Point(437, 0);
            this.lblP2.Margin = new System.Windows.Forms.Padding(0);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(63, 47);
            this.lblP2.TabIndex = 2;
            this.lblP2.Text = "P2";
            this.lblP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(0, 512);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(376, 49);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOnes
            // 
            this.lblOnes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOnes.AutoSize = true;
            this.lblOnes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnes.Location = new System.Drawing.Point(0, 47);
            this.lblOnes.Margin = new System.Windows.Forms.Padding(0);
            this.lblOnes.Name = "lblOnes";
            this.lblOnes.Size = new System.Drawing.Size(376, 31);
            this.lblOnes.TabIndex = 5;
            this.lblOnes.Text = "Ones";
            // 
            // lblTwos
            // 
            this.lblTwos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTwos.AutoSize = true;
            this.lblTwos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTwos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwos.Location = new System.Drawing.Point(0, 78);
            this.lblTwos.Margin = new System.Windows.Forms.Padding(0);
            this.lblTwos.Name = "lblTwos";
            this.lblTwos.Size = new System.Drawing.Size(376, 31);
            this.lblTwos.TabIndex = 6;
            this.lblTwos.Text = "Twos";
            // 
            // lblThrees
            // 
            this.lblThrees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThrees.AutoSize = true;
            this.lblThrees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThrees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThrees.Location = new System.Drawing.Point(0, 109);
            this.lblThrees.Margin = new System.Windows.Forms.Padding(0);
            this.lblThrees.Name = "lblThrees";
            this.lblThrees.Size = new System.Drawing.Size(376, 31);
            this.lblThrees.TabIndex = 7;
            this.lblThrees.Text = "Threes";
            // 
            // lblFours
            // 
            this.lblFours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFours.AutoSize = true;
            this.lblFours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFours.Location = new System.Drawing.Point(0, 140);
            this.lblFours.Margin = new System.Windows.Forms.Padding(0);
            this.lblFours.Name = "lblFours";
            this.lblFours.Size = new System.Drawing.Size(376, 31);
            this.lblFours.TabIndex = 8;
            this.lblFours.Text = "Fours";
            // 
            // lblFives
            // 
            this.lblFives.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFives.AutoSize = true;
            this.lblFives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFives.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFives.Location = new System.Drawing.Point(0, 171);
            this.lblFives.Margin = new System.Windows.Forms.Padding(0);
            this.lblFives.Name = "lblFives";
            this.lblFives.Size = new System.Drawing.Size(376, 31);
            this.lblFives.TabIndex = 9;
            this.lblFives.Text = "Fives";
            // 
            // lblSixes
            // 
            this.lblSixes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSixes.AutoSize = true;
            this.lblSixes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSixes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSixes.Location = new System.Drawing.Point(0, 202);
            this.lblSixes.Margin = new System.Windows.Forms.Padding(0);
            this.lblSixes.Name = "lblSixes";
            this.lblSixes.Size = new System.Drawing.Size(376, 31);
            this.lblSixes.TabIndex = 10;
            this.lblSixes.Text = "Sixes";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.BackColor = System.Drawing.Color.SteelBlue;
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(0, 233);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(376, 31);
            this.lblSubTotal.TabIndex = 11;
            this.lblSubTotal.Text = "Subtotal:";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBonus
            // 
            this.lblBonus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBonus.AutoSize = true;
            this.lblBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonus.Location = new System.Drawing.Point(0, 264);
            this.lblBonus.Margin = new System.Windows.Forms.Padding(0);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(376, 31);
            this.lblBonus.TabIndex = 12;
            this.lblBonus.Text = "Bonus - 35 (If subtotal >= 63)";
            // 
            // lbl3kind
            // 
            this.lbl3kind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl3kind.AutoSize = true;
            this.lbl3kind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3kind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3kind.Location = new System.Drawing.Point(0, 295);
            this.lbl3kind.Margin = new System.Windows.Forms.Padding(0);
            this.lbl3kind.Name = "lbl3kind";
            this.lbl3kind.Size = new System.Drawing.Size(376, 31);
            this.lbl3kind.TabIndex = 13;
            this.lbl3kind.Text = "3 of a Kind - Dice Total";
            // 
            // lbl4kind
            // 
            this.lbl4kind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl4kind.AutoSize = true;
            this.lbl4kind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4kind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4kind.Location = new System.Drawing.Point(0, 326);
            this.lbl4kind.Margin = new System.Windows.Forms.Padding(0);
            this.lbl4kind.Name = "lbl4kind";
            this.lbl4kind.Size = new System.Drawing.Size(376, 31);
            this.lbl4kind.TabIndex = 14;
            this.lbl4kind.Text = "4 of a Kind - Dice Total";
            // 
            // lblFull
            // 
            this.lblFull.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFull.AutoSize = true;
            this.lblFull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFull.Location = new System.Drawing.Point(0, 357);
            this.lblFull.Margin = new System.Windows.Forms.Padding(0);
            this.lblFull.Name = "lblFull";
            this.lblFull.Size = new System.Drawing.Size(376, 31);
            this.lblFull.TabIndex = 15;
            this.lblFull.Text = "Full House - 25";
            // 
            // lblSm
            // 
            this.lblSm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSm.AutoSize = true;
            this.lblSm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSm.Location = new System.Drawing.Point(0, 388);
            this.lblSm.Margin = new System.Windows.Forms.Padding(0);
            this.lblSm.Name = "lblSm";
            this.lblSm.Size = new System.Drawing.Size(376, 31);
            this.lblSm.TabIndex = 16;
            this.lblSm.Text = "Small Straight - 30";
            // 
            // lblLg
            // 
            this.lblLg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLg.AutoSize = true;
            this.lblLg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLg.Location = new System.Drawing.Point(0, 419);
            this.lblLg.Margin = new System.Windows.Forms.Padding(0);
            this.lblLg.Name = "lblLg";
            this.lblLg.Size = new System.Drawing.Size(376, 31);
            this.lblLg.TabIndex = 17;
            this.lblLg.Text = "Large Straight - 40";
            // 
            // lblChance
            // 
            this.lblChance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChance.AutoSize = true;
            this.lblChance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChance.Location = new System.Drawing.Point(0, 450);
            this.lblChance.Margin = new System.Windows.Forms.Padding(0);
            this.lblChance.Name = "lblChance";
            this.lblChance.Size = new System.Drawing.Size(376, 31);
            this.lblChance.TabIndex = 18;
            this.lblChance.Text = "Chance  - Dice Total";
            // 
            // lblYah
            // 
            this.lblYah.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYah.AutoSize = true;
            this.lblYah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYah.Location = new System.Drawing.Point(0, 481);
            this.lblYah.Margin = new System.Windows.Forms.Padding(0);
            this.lblYah.Name = "lblYah";
            this.lblYah.Size = new System.Drawing.Size(376, 31);
            this.lblYah.TabIndex = 19;
            this.lblYah.Text = "YAHTZEE! - 50 (+100 for each additional)";
            // 
            // lbl11
            // 
            this.lbl11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl11.AutoSize = true;
            this.lbl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl11.Location = new System.Drawing.Point(376, 47);
            this.lbl11.Margin = new System.Windows.Forms.Padding(0);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(61, 31);
            this.lbl11.TabIndex = 20;
            this.lbl11.Text = "-";
            this.lbl11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl11.Click += new System.EventHandler(this.lbl11_Click);
            // 
            // lbl12
            // 
            this.lbl12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl12.AutoSize = true;
            this.lbl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.Location = new System.Drawing.Point(376, 78);
            this.lbl12.Margin = new System.Windows.Forms.Padding(0);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(61, 31);
            this.lbl12.TabIndex = 21;
            this.lbl12.Text = "-";
            this.lbl12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl12.Click += new System.EventHandler(this.lbl12_Click);
            // 
            // lbl13
            // 
            this.lbl13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl13.AutoSize = true;
            this.lbl13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl13.Location = new System.Drawing.Point(376, 109);
            this.lbl13.Margin = new System.Windows.Forms.Padding(0);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(61, 31);
            this.lbl13.TabIndex = 22;
            this.lbl13.Text = "-";
            this.lbl13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl13.Click += new System.EventHandler(this.lbl13_Click);
            // 
            // lbl14
            // 
            this.lbl14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl14.AutoSize = true;
            this.lbl14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl14.Location = new System.Drawing.Point(376, 140);
            this.lbl14.Margin = new System.Windows.Forms.Padding(0);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(61, 31);
            this.lbl14.TabIndex = 23;
            this.lbl14.Text = "-";
            this.lbl14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl14.Click += new System.EventHandler(this.lbl14_Click);
            // 
            // lbl15
            // 
            this.lbl15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl15.AutoSize = true;
            this.lbl15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl15.Location = new System.Drawing.Point(376, 171);
            this.lbl15.Margin = new System.Windows.Forms.Padding(0);
            this.lbl15.Name = "lbl15";
            this.lbl15.Size = new System.Drawing.Size(61, 31);
            this.lbl15.TabIndex = 24;
            this.lbl15.Text = "-";
            this.lbl15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl15.Click += new System.EventHandler(this.lbl15_Click);
            // 
            // lbl16
            // 
            this.lbl16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl16.AutoSize = true;
            this.lbl16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl16.Location = new System.Drawing.Point(376, 202);
            this.lbl16.Margin = new System.Windows.Forms.Padding(0);
            this.lbl16.Name = "lbl16";
            this.lbl16.Size = new System.Drawing.Size(61, 31);
            this.lbl16.TabIndex = 25;
            this.lbl16.Text = "-";
            this.lbl16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl16.Click += new System.EventHandler(this.lbl16_Click);
            // 
            // lbl1subtot
            // 
            this.lbl1subtot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1subtot.AutoSize = true;
            this.lbl1subtot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1subtot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1subtot.Location = new System.Drawing.Point(376, 233);
            this.lbl1subtot.Margin = new System.Windows.Forms.Padding(0);
            this.lbl1subtot.Name = "lbl1subtot";
            this.lbl1subtot.Size = new System.Drawing.Size(61, 31);
            this.lbl1subtot.TabIndex = 26;
            this.lbl1subtot.Text = "0";
            this.lbl1subtot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1Bon
            // 
            this.lbl1Bon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1Bon.AutoSize = true;
            this.lbl1Bon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1Bon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Bon.Location = new System.Drawing.Point(376, 264);
            this.lbl1Bon.Margin = new System.Windows.Forms.Padding(0);
            this.lbl1Bon.Name = "lbl1Bon";
            this.lbl1Bon.Size = new System.Drawing.Size(61, 31);
            this.lbl1Bon.TabIndex = 27;
            this.lbl1Bon.Text = "-";
            this.lbl1Bon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl13K
            // 
            this.lbl13K.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl13K.AutoSize = true;
            this.lbl13K.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl13K.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl13K.Location = new System.Drawing.Point(376, 295);
            this.lbl13K.Margin = new System.Windows.Forms.Padding(0);
            this.lbl13K.Name = "lbl13K";
            this.lbl13K.Size = new System.Drawing.Size(61, 31);
            this.lbl13K.TabIndex = 28;
            this.lbl13K.Text = "-";
            this.lbl13K.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl13K.Click += new System.EventHandler(this.lbl13K_Click);
            // 
            // lbl14K
            // 
            this.lbl14K.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl14K.AutoSize = true;
            this.lbl14K.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl14K.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl14K.Location = new System.Drawing.Point(376, 326);
            this.lbl14K.Margin = new System.Windows.Forms.Padding(0);
            this.lbl14K.Name = "lbl14K";
            this.lbl14K.Size = new System.Drawing.Size(61, 31);
            this.lbl14K.TabIndex = 29;
            this.lbl14K.Text = "-";
            this.lbl14K.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl14K.Click += new System.EventHandler(this.lbl14K_Click);
            // 
            // lbl1Full
            // 
            this.lbl1Full.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1Full.AutoSize = true;
            this.lbl1Full.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1Full.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Full.Location = new System.Drawing.Point(376, 357);
            this.lbl1Full.Margin = new System.Windows.Forms.Padding(0);
            this.lbl1Full.Name = "lbl1Full";
            this.lbl1Full.Size = new System.Drawing.Size(61, 31);
            this.lbl1Full.TabIndex = 30;
            this.lbl1Full.Text = "-";
            this.lbl1Full.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl1Full.Click += new System.EventHandler(this.lbl1Full_Click);
            // 
            // lbl1Sm
            // 
            this.lbl1Sm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1Sm.AutoSize = true;
            this.lbl1Sm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1Sm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Sm.Location = new System.Drawing.Point(376, 388);
            this.lbl1Sm.Margin = new System.Windows.Forms.Padding(0);
            this.lbl1Sm.Name = "lbl1Sm";
            this.lbl1Sm.Size = new System.Drawing.Size(61, 31);
            this.lbl1Sm.TabIndex = 31;
            this.lbl1Sm.Text = "-";
            this.lbl1Sm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl1Sm.Click += new System.EventHandler(this.lbl1Sm_Click);
            // 
            // lbl1Lg
            // 
            this.lbl1Lg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1Lg.AutoSize = true;
            this.lbl1Lg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1Lg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Lg.Location = new System.Drawing.Point(376, 419);
            this.lbl1Lg.Margin = new System.Windows.Forms.Padding(0);
            this.lbl1Lg.Name = "lbl1Lg";
            this.lbl1Lg.Size = new System.Drawing.Size(61, 31);
            this.lbl1Lg.TabIndex = 32;
            this.lbl1Lg.Text = "-";
            this.lbl1Lg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl1Lg.Click += new System.EventHandler(this.lbl1Lg_Click);
            // 
            // lbl1Chan
            // 
            this.lbl1Chan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1Chan.AutoSize = true;
            this.lbl1Chan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1Chan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Chan.Location = new System.Drawing.Point(376, 450);
            this.lbl1Chan.Margin = new System.Windows.Forms.Padding(0);
            this.lbl1Chan.Name = "lbl1Chan";
            this.lbl1Chan.Size = new System.Drawing.Size(61, 31);
            this.lbl1Chan.TabIndex = 33;
            this.lbl1Chan.Text = "-";
            this.lbl1Chan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl1Chan.Click += new System.EventHandler(this.lbl1Chan_Click);
            // 
            // lbl1Yah
            // 
            this.lbl1Yah.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1Yah.AutoSize = true;
            this.lbl1Yah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1Yah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Yah.Location = new System.Drawing.Point(376, 481);
            this.lbl1Yah.Margin = new System.Windows.Forms.Padding(0);
            this.lbl1Yah.Name = "lbl1Yah";
            this.lbl1Yah.Size = new System.Drawing.Size(61, 31);
            this.lbl1Yah.TabIndex = 34;
            this.lbl1Yah.Text = "-";
            this.lbl1Yah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl1Yah.Click += new System.EventHandler(this.lbl1Yah_Click);
            // 
            // lbl1Tot
            // 
            this.lbl1Tot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1Tot.AutoSize = true;
            this.lbl1Tot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1Tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Tot.Location = new System.Drawing.Point(376, 512);
            this.lbl1Tot.Margin = new System.Windows.Forms.Padding(0);
            this.lbl1Tot.Name = "lbl1Tot";
            this.lbl1Tot.Size = new System.Drawing.Size(61, 49);
            this.lbl1Tot.TabIndex = 35;
            this.lbl1Tot.Text = "0";
            this.lbl1Tot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl21
            // 
            this.lbl21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl21.AutoSize = true;
            this.lbl21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl21.Location = new System.Drawing.Point(437, 47);
            this.lbl21.Margin = new System.Windows.Forms.Padding(0);
            this.lbl21.Name = "lbl21";
            this.lbl21.Size = new System.Drawing.Size(63, 31);
            this.lbl21.TabIndex = 36;
            this.lbl21.Text = "-";
            this.lbl21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl21.Click += new System.EventHandler(this.lbl21_Click);
            // 
            // lbl22
            // 
            this.lbl22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl22.AutoSize = true;
            this.lbl22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl22.Location = new System.Drawing.Point(437, 78);
            this.lbl22.Margin = new System.Windows.Forms.Padding(0);
            this.lbl22.Name = "lbl22";
            this.lbl22.Size = new System.Drawing.Size(63, 31);
            this.lbl22.TabIndex = 37;
            this.lbl22.Text = "-";
            this.lbl22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl22.Click += new System.EventHandler(this.lbl22_Click);
            // 
            // lbl23
            // 
            this.lbl23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl23.AutoSize = true;
            this.lbl23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl23.Location = new System.Drawing.Point(437, 109);
            this.lbl23.Margin = new System.Windows.Forms.Padding(0);
            this.lbl23.Name = "lbl23";
            this.lbl23.Size = new System.Drawing.Size(63, 31);
            this.lbl23.TabIndex = 38;
            this.lbl23.Text = "-";
            this.lbl23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl23.Click += new System.EventHandler(this.lbl23_Click);
            // 
            // lbl24
            // 
            this.lbl24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl24.AutoSize = true;
            this.lbl24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl24.Location = new System.Drawing.Point(437, 140);
            this.lbl24.Margin = new System.Windows.Forms.Padding(0);
            this.lbl24.Name = "lbl24";
            this.lbl24.Size = new System.Drawing.Size(63, 31);
            this.lbl24.TabIndex = 39;
            this.lbl24.Text = "-";
            this.lbl24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl24.Click += new System.EventHandler(this.lbl24_Click);
            // 
            // lbl25
            // 
            this.lbl25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl25.AutoSize = true;
            this.lbl25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl25.Location = new System.Drawing.Point(437, 171);
            this.lbl25.Margin = new System.Windows.Forms.Padding(0);
            this.lbl25.Name = "lbl25";
            this.lbl25.Size = new System.Drawing.Size(63, 31);
            this.lbl25.TabIndex = 40;
            this.lbl25.Text = "-";
            this.lbl25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl25.Click += new System.EventHandler(this.lbl25_Click);
            // 
            // lbl26
            // 
            this.lbl26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl26.AutoSize = true;
            this.lbl26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl26.Location = new System.Drawing.Point(437, 202);
            this.lbl26.Margin = new System.Windows.Forms.Padding(0);
            this.lbl26.Name = "lbl26";
            this.lbl26.Size = new System.Drawing.Size(63, 31);
            this.lbl26.TabIndex = 41;
            this.lbl26.Text = "-";
            this.lbl26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl26.Click += new System.EventHandler(this.lbl26_Click);
            // 
            // lbl2subtot
            // 
            this.lbl2subtot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl2subtot.AutoSize = true;
            this.lbl2subtot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2subtot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2subtot.Location = new System.Drawing.Point(437, 233);
            this.lbl2subtot.Margin = new System.Windows.Forms.Padding(0);
            this.lbl2subtot.Name = "lbl2subtot";
            this.lbl2subtot.Size = new System.Drawing.Size(63, 31);
            this.lbl2subtot.TabIndex = 42;
            this.lbl2subtot.Text = "0";
            this.lbl2subtot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2Bon
            // 
            this.lbl2Bon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl2Bon.AutoSize = true;
            this.lbl2Bon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2Bon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Bon.Location = new System.Drawing.Point(437, 264);
            this.lbl2Bon.Margin = new System.Windows.Forms.Padding(0);
            this.lbl2Bon.Name = "lbl2Bon";
            this.lbl2Bon.Size = new System.Drawing.Size(63, 31);
            this.lbl2Bon.TabIndex = 43;
            this.lbl2Bon.Text = "-";
            this.lbl2Bon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl23K
            // 
            this.lbl23K.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl23K.AutoSize = true;
            this.lbl23K.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl23K.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl23K.Location = new System.Drawing.Point(437, 295);
            this.lbl23K.Margin = new System.Windows.Forms.Padding(0);
            this.lbl23K.Name = "lbl23K";
            this.lbl23K.Size = new System.Drawing.Size(63, 31);
            this.lbl23K.TabIndex = 44;
            this.lbl23K.Text = "-";
            this.lbl23K.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl23K.Click += new System.EventHandler(this.lbl23K_Click);
            // 
            // lbl24K
            // 
            this.lbl24K.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl24K.AutoSize = true;
            this.lbl24K.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl24K.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl24K.Location = new System.Drawing.Point(437, 326);
            this.lbl24K.Margin = new System.Windows.Forms.Padding(0);
            this.lbl24K.Name = "lbl24K";
            this.lbl24K.Size = new System.Drawing.Size(63, 31);
            this.lbl24K.TabIndex = 45;
            this.lbl24K.Text = "-";
            this.lbl24K.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl24K.Click += new System.EventHandler(this.lbl24K_Click);
            // 
            // lbl2Full
            // 
            this.lbl2Full.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl2Full.AutoSize = true;
            this.lbl2Full.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2Full.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Full.Location = new System.Drawing.Point(437, 357);
            this.lbl2Full.Margin = new System.Windows.Forms.Padding(0);
            this.lbl2Full.Name = "lbl2Full";
            this.lbl2Full.Size = new System.Drawing.Size(63, 31);
            this.lbl2Full.TabIndex = 46;
            this.lbl2Full.Text = "-";
            this.lbl2Full.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl2Full.Click += new System.EventHandler(this.lbl2Full_Click);
            // 
            // lbl2Sm
            // 
            this.lbl2Sm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl2Sm.AutoSize = true;
            this.lbl2Sm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2Sm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Sm.Location = new System.Drawing.Point(437, 388);
            this.lbl2Sm.Margin = new System.Windows.Forms.Padding(0);
            this.lbl2Sm.Name = "lbl2Sm";
            this.lbl2Sm.Size = new System.Drawing.Size(63, 31);
            this.lbl2Sm.TabIndex = 47;
            this.lbl2Sm.Text = "-";
            this.lbl2Sm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl2Sm.Click += new System.EventHandler(this.lbl2Sm_Click);
            // 
            // lbl2Lg
            // 
            this.lbl2Lg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl2Lg.AutoSize = true;
            this.lbl2Lg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2Lg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Lg.Location = new System.Drawing.Point(437, 419);
            this.lbl2Lg.Margin = new System.Windows.Forms.Padding(0);
            this.lbl2Lg.Name = "lbl2Lg";
            this.lbl2Lg.Size = new System.Drawing.Size(63, 31);
            this.lbl2Lg.TabIndex = 48;
            this.lbl2Lg.Text = "-";
            this.lbl2Lg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl2Lg.Click += new System.EventHandler(this.lbl2Lg_Click);
            // 
            // lbl2Chan
            // 
            this.lbl2Chan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl2Chan.AutoSize = true;
            this.lbl2Chan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2Chan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Chan.Location = new System.Drawing.Point(437, 450);
            this.lbl2Chan.Margin = new System.Windows.Forms.Padding(0);
            this.lbl2Chan.Name = "lbl2Chan";
            this.lbl2Chan.Size = new System.Drawing.Size(63, 31);
            this.lbl2Chan.TabIndex = 49;
            this.lbl2Chan.Text = "-";
            this.lbl2Chan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl2Chan.Click += new System.EventHandler(this.lbl2Chan_Click);
            // 
            // lbl2Yah
            // 
            this.lbl2Yah.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl2Yah.AutoSize = true;
            this.lbl2Yah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2Yah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Yah.Location = new System.Drawing.Point(437, 481);
            this.lbl2Yah.Margin = new System.Windows.Forms.Padding(0);
            this.lbl2Yah.Name = "lbl2Yah";
            this.lbl2Yah.Size = new System.Drawing.Size(63, 31);
            this.lbl2Yah.TabIndex = 50;
            this.lbl2Yah.Text = "-";
            this.lbl2Yah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl2Yah.Click += new System.EventHandler(this.lbl2Yah_Click);
            // 
            // lbl2Tot
            // 
            this.lbl2Tot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl2Tot.AutoSize = true;
            this.lbl2Tot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2Tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Tot.Location = new System.Drawing.Point(437, 512);
            this.lbl2Tot.Margin = new System.Windows.Forms.Padding(0);
            this.lbl2Tot.Name = "lbl2Tot";
            this.lbl2Tot.Size = new System.Drawing.Size(63, 49);
            this.lbl2Tot.TabIndex = 51;
            this.lbl2Tot.Text = "0";
            this.lbl2Tot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRoll
            // 
            this.btnRoll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(242, 3);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(233, 94);
            this.btnRoll.TabIndex = 1;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnKeepScore
            // 
            this.btnKeepScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKeepScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeepScore.Location = new System.Drawing.Point(3, 3);
            this.btnKeepScore.Name = "btnKeepScore";
            this.btnKeepScore.Size = new System.Drawing.Size(233, 94);
            this.btnKeepScore.TabIndex = 0;
            this.btnKeepScore.Text = "Keep Score";
            this.btnKeepScore.UseVisualStyleBackColor = true;
            this.btnKeepScore.Click += new System.EventHandler(this.btnKeepScore_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.ColumnCount = 2;
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlButtons.Controls.Add(this.btnKeepScore, 0, 0);
            this.pnlButtons.Controls.Add(this.btnRoll, 1, 0);
            this.pnlButtons.Location = new System.Drawing.Point(506, 461);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RowCount = 1;
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlButtons.Size = new System.Drawing.Size(478, 100);
            this.pnlButtons.TabIndex = 0;
            // 
            // pnlDice
            // 
            this.pnlDice.ColumnCount = 6;
            this.pnlDice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlDice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlDice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlDice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlDice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlDice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlDice.Controls.Add(this.lblDie1, 0, 0);
            this.pnlDice.Controls.Add(this.lblDie2, 2, 0);
            this.pnlDice.Controls.Add(this.lblDie3, 4, 0);
            this.pnlDice.Controls.Add(this.lblDie4, 1, 1);
            this.pnlDice.Controls.Add(this.lblDie5, 3, 1);
            this.pnlDice.Location = new System.Drawing.Point(520, 143);
            this.pnlDice.Name = "pnlDice";
            this.pnlDice.RowCount = 2;
            this.pnlDice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlDice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlDice.Size = new System.Drawing.Size(450, 241);
            this.pnlDice.TabIndex = 2;
            // 
            // lblDie1
            // 
            this.lblDie1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDie1.AutoSize = true;
            this.lblDie1.BackColor = System.Drawing.Color.White;
            this.pnlDice.SetColumnSpan(this.lblDie1, 2);
            this.lblDie1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDie1.Location = new System.Drawing.Point(10, 10);
            this.lblDie1.Margin = new System.Windows.Forms.Padding(10);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(128, 100);
            this.lblDie1.TabIndex = 0;
            this.lblDie1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDie1.Click += new System.EventHandler(this.lblDie1_Click);
            // 
            // lblDie2
            // 
            this.lblDie2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDie2.AutoSize = true;
            this.lblDie2.BackColor = System.Drawing.Color.White;
            this.pnlDice.SetColumnSpan(this.lblDie2, 2);
            this.lblDie2.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDie2.Location = new System.Drawing.Point(158, 10);
            this.lblDie2.Margin = new System.Windows.Forms.Padding(10);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(128, 100);
            this.lblDie2.TabIndex = 1;
            this.lblDie2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDie2.Click += new System.EventHandler(this.lblDie2_Click);
            // 
            // lblDie3
            // 
            this.lblDie3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDie3.AutoSize = true;
            this.lblDie3.BackColor = System.Drawing.Color.White;
            this.pnlDice.SetColumnSpan(this.lblDie3, 2);
            this.lblDie3.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDie3.Location = new System.Drawing.Point(306, 10);
            this.lblDie3.Margin = new System.Windows.Forms.Padding(10);
            this.lblDie3.Name = "lblDie3";
            this.lblDie3.Size = new System.Drawing.Size(134, 100);
            this.lblDie3.TabIndex = 2;
            this.lblDie3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDie3.Click += new System.EventHandler(this.lblDie3_Click);
            // 
            // lblDie4
            // 
            this.lblDie4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDie4.AutoSize = true;
            this.lblDie4.BackColor = System.Drawing.Color.White;
            this.pnlDice.SetColumnSpan(this.lblDie4, 2);
            this.lblDie4.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDie4.Location = new System.Drawing.Point(84, 130);
            this.lblDie4.Margin = new System.Windows.Forms.Padding(10);
            this.lblDie4.Name = "lblDie4";
            this.lblDie4.Size = new System.Drawing.Size(128, 101);
            this.lblDie4.TabIndex = 4;
            this.lblDie4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDie4.Click += new System.EventHandler(this.lblDie4_Click);
            // 
            // lblDie5
            // 
            this.lblDie5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDie5.AutoSize = true;
            this.lblDie5.BackColor = System.Drawing.Color.White;
            this.pnlDice.SetColumnSpan(this.lblDie5, 2);
            this.lblDie5.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDie5.Location = new System.Drawing.Point(232, 130);
            this.lblDie5.Margin = new System.Windows.Forms.Padding(10);
            this.lblDie5.Name = "lblDie5";
            this.lblDie5.Size = new System.Drawing.Size(128, 101);
            this.lblDie5.TabIndex = 3;
            this.lblDie5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDie5.Click += new System.EventHandler(this.lblDie5_Click);
            // 
            // lblMsgs
            // 
            this.lblMsgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgs.Location = new System.Drawing.Point(612, 50);
            this.lblMsgs.Name = "lblMsgs";
            this.lblMsgs.Size = new System.Drawing.Size(268, 55);
            this.lblMsgs.TabIndex = 3;
            this.lblMsgs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblMsgs);
            this.Controls.Add(this.pnlDice);
            this.Controls.Add(this.pnlScores);
            this.Controls.Add(this.pnlButtons);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yahtzee Game!";
            this.Shown += new System.EventHandler(this.Game_Shown);
            this.pnlScores.ResumeLayout(false);
            this.pnlScores.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlDice.ResumeLayout(false);
            this.pnlDice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlScores;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnKeepScore;
        private System.Windows.Forms.TableLayoutPanel pnlButtons;
        private System.Windows.Forms.TableLayoutPanel pnlDice;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOnes;
        private System.Windows.Forms.Label lblTwos;
        private System.Windows.Forms.Label lblThrees;
        private System.Windows.Forms.Label lblFours;
        private System.Windows.Forms.Label lblFives;
        private System.Windows.Forms.Label lblSixes;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lbl3kind;
        private System.Windows.Forms.Label lbl4kind;
        private System.Windows.Forms.Label lblFull;
        private System.Windows.Forms.Label lblSm;
        private System.Windows.Forms.Label lblLg;
        private System.Windows.Forms.Label lblChance;
        private System.Windows.Forms.Label lblYah;
        private System.Windows.Forms.Label lblDie1;
        private System.Windows.Forms.Label lblDie2;
        private System.Windows.Forms.Label lblDie3;
        private System.Windows.Forms.Label lblDie5;
        private System.Windows.Forms.Label lblDie4;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.Label lbl15;
        private System.Windows.Forms.Label lbl16;
        private System.Windows.Forms.Label lbl1subtot;
        private System.Windows.Forms.Label lbl1Bon;
        private System.Windows.Forms.Label lbl13K;
        private System.Windows.Forms.Label lbl14K;
        private System.Windows.Forms.Label lbl1Full;
        private System.Windows.Forms.Label lbl1Sm;
        private System.Windows.Forms.Label lbl1Lg;
        private System.Windows.Forms.Label lbl1Chan;
        private System.Windows.Forms.Label lbl1Yah;
        private System.Windows.Forms.Label lbl1Tot;
        private System.Windows.Forms.Label lblMsgs;
        private System.Windows.Forms.Label lbl21;
        private System.Windows.Forms.Label lbl22;
        private System.Windows.Forms.Label lbl23;
        private System.Windows.Forms.Label lbl24;
        private System.Windows.Forms.Label lbl25;
        private System.Windows.Forms.Label lbl26;
        private System.Windows.Forms.Label lbl2subtot;
        private System.Windows.Forms.Label lbl2Bon;
        private System.Windows.Forms.Label lbl23K;
        private System.Windows.Forms.Label lbl24K;
        private System.Windows.Forms.Label lbl2Full;
        private System.Windows.Forms.Label lbl2Sm;
        private System.Windows.Forms.Label lbl2Lg;
        private System.Windows.Forms.Label lbl2Chan;
        private System.Windows.Forms.Label lbl2Yah;
        private System.Windows.Forms.Label lbl2Tot;
    }
}

