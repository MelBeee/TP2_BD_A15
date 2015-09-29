namespace Tp2BD_Parti1
{
	partial class Form1
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.TB_IdInventaire = new System.Windows.Forms.TextBox();
            this.TB_QteStock = new System.Windows.Forms.TextBox();
            this.TB_QteMin = new System.Windows.Forms.TextBox();
            this.TB_QteMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_IdFournisseur = new System.Windows.Forms.ComboBox();
            this.BT_ModifierFournisseur = new System.Windows.Forms.Button();
            this.BT_SupprimerFournisseur = new System.Windows.Forms.Button();
            this.BT_AjouterFournisseur = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_RechercheDescription = new System.Windows.Forms.TextBox();
            this.BT_RechercheDescription = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BT_AjouterInventaire = new System.Windows.Forms.Button();
            this.BT_SupprimerInventaire = new System.Windows.Forms.Button();
            this.TB_Description = new System.Windows.Forms.TextBox();
            this.BT_ModifierInventaire = new System.Windows.Forms.Button();
            this.DGV_Produit = new System.Windows.Forms.DataGridView();
            this.TB_IdFournisseur = new System.Windows.Forms.TextBox();
            this.TB_AdFournisseur = new System.Windows.Forms.TextBox();
            this.TB_VilleFournisseur = new System.Windows.Forms.TextBox();
            this.TB_NomFournisseur = new System.Windows.Forms.TextBox();
            this.TB_CPFFournisseur = new System.Windows.Forms.TextBox();
            this.TB_TelFournisseur = new System.Windows.Forms.TextBox();
            this.TB_SoldeFournisseur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TB_CourrielFournisseur = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TB_RechercheNom = new System.Windows.Forms.TextBox();
            this.BT_RechercheNom = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Produit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_IdInventaire
            // 
            this.TB_IdInventaire.Location = new System.Drawing.Point(89, 63);
            this.TB_IdInventaire.Name = "TB_IdInventaire";
            this.TB_IdInventaire.Size = new System.Drawing.Size(100, 20);
            this.TB_IdInventaire.TabIndex = 6;
            this.TB_IdInventaire.TextChanged += new System.EventHandler(this.TB_IdInventaire_TextChanged);
            // 
            // TB_QteStock
            // 
            this.TB_QteStock.Location = new System.Drawing.Point(89, 115);
            this.TB_QteStock.Name = "TB_QteStock";
            this.TB_QteStock.Size = new System.Drawing.Size(100, 20);
            this.TB_QteStock.TabIndex = 9;
            this.TB_QteStock.TextChanged += new System.EventHandler(this.TB_QteStock_TextChanged);
            // 
            // TB_QteMin
            // 
            this.TB_QteMin.Location = new System.Drawing.Point(89, 141);
            this.TB_QteMin.Name = "TB_QteMin";
            this.TB_QteMin.Size = new System.Drawing.Size(100, 20);
            this.TB_QteMin.TabIndex = 10;
            this.TB_QteMin.TextChanged += new System.EventHandler(this.TB_QteMin_TextChanged);
            // 
            // TB_QteMax
            // 
            this.TB_QteMax.Location = new System.Drawing.Point(89, 167);
            this.TB_QteMax.Name = "TB_QteMax";
            this.TB_QteMax.Size = new System.Drawing.Size(100, 20);
            this.TB_QteMax.TabIndex = 11;
            this.TB_QteMax.TextChanged += new System.EventHandler(this.TB_QteMax_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id Inventaire :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Id Fournisseur :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Quantité Stock :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quantité Min :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quantité Max :";
            // 
            // CB_IdFournisseur
            // 
            this.CB_IdFournisseur.FormattingEnabled = true;
            this.CB_IdFournisseur.Location = new System.Drawing.Point(89, 88);
            this.CB_IdFournisseur.Name = "CB_IdFournisseur";
            this.CB_IdFournisseur.Size = new System.Drawing.Size(100, 21);
            this.CB_IdFournisseur.TabIndex = 18;
            this.CB_IdFournisseur.SelectedIndexChanged += new System.EventHandler(this.CB_IdFournisseur_SelectedIndexChanged);
            // 
            // BT_ModifierFournisseur
            // 
            this.BT_ModifierFournisseur.Enabled = false;
            this.BT_ModifierFournisseur.Location = new System.Drawing.Point(181, 353);
            this.BT_ModifierFournisseur.Name = "BT_ModifierFournisseur";
            this.BT_ModifierFournisseur.Size = new System.Drawing.Size(75, 23);
            this.BT_ModifierFournisseur.TabIndex = 24;
            this.BT_ModifierFournisseur.Text = "Modifier";
            this.BT_ModifierFournisseur.UseVisualStyleBackColor = true;
            // 
            // BT_SupprimerFournisseur
            // 
            this.BT_SupprimerFournisseur.Enabled = false;
            this.BT_SupprimerFournisseur.Location = new System.Drawing.Point(97, 353);
            this.BT_SupprimerFournisseur.Name = "BT_SupprimerFournisseur";
            this.BT_SupprimerFournisseur.Size = new System.Drawing.Size(75, 23);
            this.BT_SupprimerFournisseur.TabIndex = 23;
            this.BT_SupprimerFournisseur.Text = "Supprimer";
            this.BT_SupprimerFournisseur.UseVisualStyleBackColor = true;
            // 
            // BT_AjouterFournisseur
            // 
            this.BT_AjouterFournisseur.Location = new System.Drawing.Point(16, 353);
            this.BT_AjouterFournisseur.Name = "BT_AjouterFournisseur";
            this.BT_AjouterFournisseur.Size = new System.Drawing.Size(75, 23);
            this.BT_AjouterFournisseur.TabIndex = 22;
            this.BT_AjouterFournisseur.Text = "Ajouter";
            this.BT_AjouterFournisseur.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TB_RechercheDescription);
            this.groupBox2.Controls.Add(this.BT_RechercheDescription);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.BT_AjouterInventaire);
            this.groupBox2.Controls.Add(this.BT_SupprimerInventaire);
            this.groupBox2.Controls.Add(this.CB_IdFournisseur);
            this.groupBox2.Controls.Add(this.TB_Description);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BT_ModifierInventaire);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TB_IdInventaire);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TB_QteStock);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TB_QteMin);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TB_QteMax);
            this.groupBox2.Location = new System.Drawing.Point(4, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 383);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventaire";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Recherche par description : ";
            // 
            // TB_RechercheDescription
            // 
            this.TB_RechercheDescription.Location = new System.Drawing.Point(6, 32);
            this.TB_RechercheDescription.Name = "TB_RechercheDescription";
            this.TB_RechercheDescription.Size = new System.Drawing.Size(160, 20);
            this.TB_RechercheDescription.TabIndex = 20;
            this.TB_RechercheDescription.TextChanged += new System.EventHandler(this.TB_RechercheDescription_TextChanged);
            // 
            // BT_RechercheDescription
            // 
            this.BT_RechercheDescription.Location = new System.Drawing.Point(172, 30);
            this.BT_RechercheDescription.Name = "BT_RechercheDescription";
            this.BT_RechercheDescription.Size = new System.Drawing.Size(75, 23);
            this.BT_RechercheDescription.TabIndex = 21;
            this.BT_RechercheDescription.Text = "Recherche";
            this.BT_RechercheDescription.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Description :";
            // 
            // BT_AjouterInventaire
            // 
            this.BT_AjouterInventaire.Location = new System.Drawing.Point(8, 354);
            this.BT_AjouterInventaire.Name = "BT_AjouterInventaire";
            this.BT_AjouterInventaire.Size = new System.Drawing.Size(75, 23);
            this.BT_AjouterInventaire.TabIndex = 0;
            this.BT_AjouterInventaire.Text = "Ajouter";
            this.BT_AjouterInventaire.UseVisualStyleBackColor = true;
            this.BT_AjouterInventaire.Click += new System.EventHandler(this.BT_AjouterInventaire_Click);
            // 
            // BT_SupprimerInventaire
            // 
            this.BT_SupprimerInventaire.Enabled = false;
            this.BT_SupprimerInventaire.Location = new System.Drawing.Point(89, 354);
            this.BT_SupprimerInventaire.Name = "BT_SupprimerInventaire";
            this.BT_SupprimerInventaire.Size = new System.Drawing.Size(75, 23);
            this.BT_SupprimerInventaire.TabIndex = 1;
            this.BT_SupprimerInventaire.Text = "Supprimer";
            this.BT_SupprimerInventaire.UseVisualStyleBackColor = true;
            // 
            // TB_Description
            // 
            this.TB_Description.Location = new System.Drawing.Point(6, 207);
            this.TB_Description.Multiline = true;
            this.TB_Description.Name = "TB_Description";
            this.TB_Description.Size = new System.Drawing.Size(240, 138);
            this.TB_Description.TabIndex = 7;
            this.TB_Description.TextChanged += new System.EventHandler(this.TB_Description_TextChanged);
            // 
            // BT_ModifierInventaire
            // 
            this.BT_ModifierInventaire.Enabled = false;
            this.BT_ModifierInventaire.Location = new System.Drawing.Point(173, 354);
            this.BT_ModifierInventaire.Name = "BT_ModifierInventaire";
            this.BT_ModifierInventaire.Size = new System.Drawing.Size(75, 23);
            this.BT_ModifierInventaire.TabIndex = 2;
            this.BT_ModifierInventaire.Text = "Modifier";
            this.BT_ModifierInventaire.UseVisualStyleBackColor = true;
            // 
            // DGV_Produit
            // 
            this.DGV_Produit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Produit.Location = new System.Drawing.Point(553, 7);
            this.DGV_Produit.Name = "DGV_Produit";
            this.DGV_Produit.Size = new System.Drawing.Size(287, 371);
            this.DGV_Produit.TabIndex = 25;
            // 
            // TB_IdFournisseur
            // 
            this.TB_IdFournisseur.Location = new System.Drawing.Point(94, 68);
            this.TB_IdFournisseur.Name = "TB_IdFournisseur";
            this.TB_IdFournisseur.Size = new System.Drawing.Size(100, 20);
            this.TB_IdFournisseur.TabIndex = 26;
            this.TB_IdFournisseur.TextChanged += new System.EventHandler(this.TB_IdFournisseur_TextChanged);
            // 
            // TB_AdFournisseur
            // 
            this.TB_AdFournisseur.Location = new System.Drawing.Point(94, 120);
            this.TB_AdFournisseur.Name = "TB_AdFournisseur";
            this.TB_AdFournisseur.Size = new System.Drawing.Size(100, 20);
            this.TB_AdFournisseur.TabIndex = 27;
            this.TB_AdFournisseur.TextChanged += new System.EventHandler(this.TB_AdFournisseur_TextChanged);
            // 
            // TB_VilleFournisseur
            // 
            this.TB_VilleFournisseur.Location = new System.Drawing.Point(94, 146);
            this.TB_VilleFournisseur.Name = "TB_VilleFournisseur";
            this.TB_VilleFournisseur.Size = new System.Drawing.Size(100, 20);
            this.TB_VilleFournisseur.TabIndex = 29;
            this.TB_VilleFournisseur.TextChanged += new System.EventHandler(this.TB_VilleFournisseur_TextChanged);
            // 
            // TB_NomFournisseur
            // 
            this.TB_NomFournisseur.Location = new System.Drawing.Point(94, 94);
            this.TB_NomFournisseur.Name = "TB_NomFournisseur";
            this.TB_NomFournisseur.Size = new System.Drawing.Size(100, 20);
            this.TB_NomFournisseur.TabIndex = 30;
            this.TB_NomFournisseur.TextChanged += new System.EventHandler(this.TB_NomFournisseur_TextChanged);
            // 
            // TB_CPFFournisseur
            // 
            this.TB_CPFFournisseur.Location = new System.Drawing.Point(94, 172);
            this.TB_CPFFournisseur.Name = "TB_CPFFournisseur";
            this.TB_CPFFournisseur.Size = new System.Drawing.Size(100, 20);
            this.TB_CPFFournisseur.TabIndex = 31;
            this.TB_CPFFournisseur.TextChanged += new System.EventHandler(this.TB_CPFFournisseur_TextChanged);
            // 
            // TB_TelFournisseur
            // 
            this.TB_TelFournisseur.Location = new System.Drawing.Point(94, 198);
            this.TB_TelFournisseur.Name = "TB_TelFournisseur";
            this.TB_TelFournisseur.Size = new System.Drawing.Size(100, 20);
            this.TB_TelFournisseur.TabIndex = 32;
            this.TB_TelFournisseur.TextChanged += new System.EventHandler(this.TB_TelFournisseur_TextChanged);
            // 
            // TB_SoldeFournisseur
            // 
            this.TB_SoldeFournisseur.Location = new System.Drawing.Point(94, 224);
            this.TB_SoldeFournisseur.Name = "TB_SoldeFournisseur";
            this.TB_SoldeFournisseur.Size = new System.Drawing.Size(100, 20);
            this.TB_SoldeFournisseur.TabIndex = 33;
            this.TB_SoldeFournisseur.TextChanged += new System.EventHandler(this.TB_SoldeFournisseur_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ville :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Addresse :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Nom :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Id :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(277, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 227);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Solde :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Telephone";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 175);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "CPF :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Courriel :";
            // 
            // TB_CourrielFournisseur
            // 
            this.TB_CourrielFournisseur.Location = new System.Drawing.Point(94, 250);
            this.TB_CourrielFournisseur.Name = "TB_CourrielFournisseur";
            this.TB_CourrielFournisseur.Size = new System.Drawing.Size(100, 20);
            this.TB_CourrielFournisseur.TabIndex = 37;
            this.TB_CourrielFournisseur.TextChanged += new System.EventHandler(this.TB_CourrielFournisseur_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Recherche par nom: ";
            // 
            // TB_RechercheNom
            // 
            this.TB_RechercheNom.Location = new System.Drawing.Point(9, 32);
            this.TB_RechercheNom.Name = "TB_RechercheNom";
            this.TB_RechercheNom.Size = new System.Drawing.Size(160, 20);
            this.TB_RechercheNom.TabIndex = 23;
            this.TB_RechercheNom.TextChanged += new System.EventHandler(this.TB_RechercheNom_TextChanged);
            // 
            // BT_RechercheNom
            // 
            this.BT_RechercheNom.Location = new System.Drawing.Point(175, 30);
            this.BT_RechercheNom.Name = "BT_RechercheNom";
            this.BT_RechercheNom.Size = new System.Drawing.Size(75, 23);
            this.BT_RechercheNom.TabIndex = 24;
            this.BT_RechercheNom.Text = "Recherche";
            this.BT_RechercheNom.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TB_RechercheNom);
            this.groupBox1.Controls.Add(this.BT_AjouterFournisseur);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.BT_SupprimerFournisseur);
            this.groupBox1.Controls.Add(this.BT_RechercheNom);
            this.groupBox1.Controls.Add(this.BT_ModifierFournisseur);
            this.groupBox1.Controls.Add(this.TB_CourrielFournisseur);
            this.groupBox1.Controls.Add(this.TB_VilleFournisseur);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.TB_AdFournisseur);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.TB_IdFournisseur);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.TB_NomFournisseur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TB_CPFFournisseur);
            this.groupBox1.Controls.Add(this.TB_SoldeFournisseur);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TB_TelFournisseur);
            this.groupBox1.Location = new System.Drawing.Point(264, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 383);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fournisseur";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 389);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DGV_Produit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Produit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TB_IdInventaire;
		private System.Windows.Forms.TextBox TB_QteStock;
		private System.Windows.Forms.TextBox TB_QteMin;
		private System.Windows.Forms.TextBox TB_QteMax;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox CB_IdFournisseur;
		private System.Windows.Forms.Button BT_ModifierFournisseur;
		private System.Windows.Forms.Button BT_SupprimerFournisseur;
		private System.Windows.Forms.Button BT_AjouterFournisseur;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox TB_RechercheDescription;
		private System.Windows.Forms.Button BT_RechercheDescription;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button BT_AjouterInventaire;
		private System.Windows.Forms.Button BT_SupprimerInventaire;
		private System.Windows.Forms.TextBox TB_Description;
		private System.Windows.Forms.Button BT_ModifierInventaire;
		private System.Windows.Forms.DataGridView DGV_Produit;
		private System.Windows.Forms.TextBox TB_IdFournisseur;
		private System.Windows.Forms.TextBox TB_AdFournisseur;
		private System.Windows.Forms.TextBox TB_VilleFournisseur;
		private System.Windows.Forms.TextBox TB_NomFournisseur;
		private System.Windows.Forms.TextBox TB_CPFFournisseur;
		private System.Windows.Forms.TextBox TB_TelFournisseur;
		private System.Windows.Forms.TextBox TB_SoldeFournisseur;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox TB_CourrielFournisseur;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox TB_RechercheNom;
		private System.Windows.Forms.Button BT_RechercheNom;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

