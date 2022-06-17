
namespace exercise_CRUD
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.exercise_PabdDataSet = new exercise_CRUD.Exercise_PabdDataSet();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter = new exercise_CRUD.Exercise_PabdDataSetTableAdapters.mahasiswaTableAdapter();
            this.exercise_PabdDataSet1 = new exercise_CRUD.Exercise_PabdDataSet1();
            this.mahasiswaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter1 = new exercise_CRUD.Exercise_PabdDataSet1TableAdapters.mahasiswaTableAdapter();
            this.exercise_PabdDataSet2 = new exercise_CRUD.Exercise_PabdDataSet2();
            this.mahasiswaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter2 = new exercise_CRUD.Exercise_PabdDataSet2TableAdapters.mahasiswaTableAdapter();
            this.exercise_PabdDataSet3 = new exercise_CRUD.Exercise_PabdDataSet3();
            this.dosenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dosenTableAdapter = new exercise_CRUD.Exercise_PabdDataSet3TableAdapters.dosenTableAdapter();
            this.dosenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dosenBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.asdosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asdosTableAdapter = new exercise_CRUD.Exercise_PabdDataSet3TableAdapters.asdosTableAdapter();
            this.asdosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.asdosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.exercise_PabdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercise_PabdDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercise_PabdDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercise_PabdDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asdosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asdosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asdosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dosenBindingSource, "Data_Dosen", true));
            this.textBox1.Location = new System.Drawing.Point(342, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asdosBindingSource, "Data_Asdos", true));
            this.textBox2.Location = new System.Drawing.Point(590, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 1;
            // 
            // Nama
            // 
            this.Nama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "Data_Mahasiswa", true));
            this.Nama.Location = new System.Drawing.Point(96, 167);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(100, 26);
            this.Nama.TabIndex = 2;
            this.Nama.TextChanged += new System.EventHandler(this.Nama_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource1, "Nim", true));
            this.textBox4.Location = new System.Drawing.Point(96, 249);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource2, "Jenis_Kelamin", true));
            this.textBox5.Location = new System.Drawing.Point(96, 331);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dosenBindingSource1, "Jenis_KElamin", true));
            this.textBox6.Location = new System.Drawing.Point(342, 249);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 26);
            this.textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dosenBindingSource2, "No_Telpon", true));
            this.textBox7.Location = new System.Drawing.Point(342, 331);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 26);
            this.textBox7.TabIndex = 9;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asdosBindingSource2, "Jenis_Kelamin", true));
            this.textBox8.Location = new System.Drawing.Point(590, 260);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 26);
            this.textBox8.TabIndex = 10;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asdosBindingSource1, "No_Telp", true));
            this.textBox9.Location = new System.Drawing.Point(590, 330);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 26);
            this.textBox9.TabIndex = 11;
            // 
            // exercise_PabdDataSet
            // 
            this.exercise_PabdDataSet.DataSetName = "Exercise_PabdDataSet";
            this.exercise_PabdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.exercise_PabdDataSet;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // exercise_PabdDataSet1
            // 
            this.exercise_PabdDataSet1.DataSetName = "Exercise_PabdDataSet1";
            this.exercise_PabdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource1
            // 
            this.mahasiswaBindingSource1.DataMember = "mahasiswa";
            this.mahasiswaBindingSource1.DataSource = this.exercise_PabdDataSet1;
            // 
            // mahasiswaTableAdapter1
            // 
            this.mahasiswaTableAdapter1.ClearBeforeFill = true;
            // 
            // exercise_PabdDataSet2
            // 
            this.exercise_PabdDataSet2.DataSetName = "Exercise_PabdDataSet2";
            this.exercise_PabdDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource2
            // 
            this.mahasiswaBindingSource2.DataMember = "mahasiswa";
            this.mahasiswaBindingSource2.DataSource = this.exercise_PabdDataSet2;
            // 
            // mahasiswaTableAdapter2
            // 
            this.mahasiswaTableAdapter2.ClearBeforeFill = true;
            // 
            // exercise_PabdDataSet3
            // 
            this.exercise_PabdDataSet3.DataSetName = "Exercise_PabdDataSet3";
            this.exercise_PabdDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dosenBindingSource
            // 
            this.dosenBindingSource.DataMember = "dosen";
            this.dosenBindingSource.DataSource = this.exercise_PabdDataSet3;
            // 
            // dosenTableAdapter
            // 
            this.dosenTableAdapter.ClearBeforeFill = true;
            // 
            // dosenBindingSource1
            // 
            this.dosenBindingSource1.DataMember = "dosen";
            this.dosenBindingSource1.DataSource = this.exercise_PabdDataSet3;
            // 
            // dosenBindingSource2
            // 
            this.dosenBindingSource2.DataMember = "dosen";
            this.dosenBindingSource2.DataSource = this.exercise_PabdDataSet3;
            // 
            // asdosBindingSource
            // 
            this.asdosBindingSource.DataMember = "asdos";
            this.asdosBindingSource.DataSource = this.exercise_PabdDataSet3;
            // 
            // asdosTableAdapter
            // 
            this.asdosTableAdapter.ClearBeforeFill = true;
            // 
            // asdosBindingSource1
            // 
            this.asdosBindingSource1.DataMember = "asdos";
            this.asdosBindingSource1.DataSource = this.exercise_PabdDataSet3;
            // 
            // asdosBindingSource2
            // 
            this.asdosBindingSource2.DataMember = "asdos";
            this.asdosBindingSource2.DataSource = this.exercise_PabdDataSet3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::exercise_CRUD.Properties.Resources.pexels_giorgio_de_angelis_1413412;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exercise_PabdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercise_PabdDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercise_PabdDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercise_PabdDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asdosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asdosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asdosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private Exercise_PabdDataSet exercise_PabdDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private Exercise_PabdDataSetTableAdapters.mahasiswaTableAdapter mahasiswaTableAdapter;
        private Exercise_PabdDataSet1 exercise_PabdDataSet1;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource1;
        private Exercise_PabdDataSet1TableAdapters.mahasiswaTableAdapter mahasiswaTableAdapter1;
        private Exercise_PabdDataSet2 exercise_PabdDataSet2;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource2;
        private Exercise_PabdDataSet2TableAdapters.mahasiswaTableAdapter mahasiswaTableAdapter2;
        private Exercise_PabdDataSet3 exercise_PabdDataSet3;
        private System.Windows.Forms.BindingSource dosenBindingSource;
        private Exercise_PabdDataSet3TableAdapters.dosenTableAdapter dosenTableAdapter;
        private System.Windows.Forms.BindingSource dosenBindingSource1;
        private System.Windows.Forms.BindingSource dosenBindingSource2;
        private System.Windows.Forms.BindingSource asdosBindingSource;
        private Exercise_PabdDataSet3TableAdapters.asdosTableAdapter asdosTableAdapter;
        private System.Windows.Forms.BindingSource asdosBindingSource2;
        private System.Windows.Forms.BindingSource asdosBindingSource1;
    }
}

