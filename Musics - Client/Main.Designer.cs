﻿namespace Musics___Client
{
    partial class Client
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
            this.components = new System.ComponentModel.Container();
            this.HueTimer = new System.Windows.Forms.Timer(this.components);
            this.UIAdministration = new System.Windows.Forms.TabPage();
            this.UIAdministrationServers = new System.Windows.Forms.ComboBox();
            this.UIPanelEditUser = new System.Windows.Forms.Panel();
            this.UIEditUserConfirm = new System.Windows.Forms.Button();
            this.UIEditUserRank = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.UIAdminUID = new System.Windows.Forms.Label();
            this.UIAdminUser = new System.Windows.Forms.Label();
            this.UIUsersResult = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.UISearchUser = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.UISettings = new System.Windows.Forms.TabPage();
            this.hueControl1 = new ControlLibrary.User_Interface.HueControl();
            this.label1 = new System.Windows.Forms.Label();
            this.UIAccount = new System.Windows.Forms.TabPage();
            this.AccountControl = new Musics___Client.UI.AccountControl();
            this.UIFavorites = new System.Windows.Forms.TabPage();
            this.FavoriteControl = new Musics___Client.UI.FavoriteControl();
            this.UISearch = new System.Windows.Forms.TabPage();
            this.SearchControl = new Musics___Client.UI.SearchControl();
            this.UIHome = new System.Windows.Forms.TabPage();
            this.homeControl1 = new Musics___Client.UI.HomeControl();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.UITracker = new Musics___Client.UI.TrackerControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.uPlayer1 = new ControlLibrary.UPlayer();
            this.UIAdministration.SuspendLayout();
            this.UIPanelEditUser.SuspendLayout();
            this.UISettings.SuspendLayout();
            this.UIAccount.SuspendLayout();
            this.UIFavorites.SuspendLayout();
            this.UISearch.SuspendLayout();
            this.UIHome.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // UIAdministration
            // 
            this.UIAdministration.Controls.Add(this.UIAdministrationServers);
            this.UIAdministration.Controls.Add(this.UIPanelEditUser);
            this.UIAdministration.Controls.Add(this.UIUsersResult);
            this.UIAdministration.Controls.Add(this.label19);
            this.UIAdministration.Controls.Add(this.UISearchUser);
            this.UIAdministration.Controls.Add(this.label18);
            this.UIAdministration.Location = new System.Drawing.Point(4, 34);
            this.UIAdministration.Name = "UIAdministration";
            this.UIAdministration.Padding = new System.Windows.Forms.Padding(3);
            this.UIAdministration.Size = new System.Drawing.Size(1897, 900);
            this.UIAdministration.TabIndex = 8;
            this.UIAdministration.Text = "Administration";
            this.UIAdministration.UseVisualStyleBackColor = true;
            // 
            // UIAdministrationServers
            // 
            this.UIAdministrationServers.FormattingEnabled = true;
            this.UIAdministrationServers.Location = new System.Drawing.Point(475, 94);
            this.UIAdministrationServers.Name = "UIAdministrationServers";
            this.UIAdministrationServers.Size = new System.Drawing.Size(229, 33);
            this.UIAdministrationServers.TabIndex = 37;
            // 
            // UIPanelEditUser
            // 
            this.UIPanelEditUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UIPanelEditUser.Controls.Add(this.UIEditUserConfirm);
            this.UIPanelEditUser.Controls.Add(this.UIEditUserRank);
            this.UIPanelEditUser.Controls.Add(this.label20);
            this.UIPanelEditUser.Controls.Add(this.UIAdminUID);
            this.UIPanelEditUser.Controls.Add(this.UIAdminUser);
            this.UIPanelEditUser.Location = new System.Drawing.Point(22, 341);
            this.UIPanelEditUser.Name = "UIPanelEditUser";
            this.UIPanelEditUser.Size = new System.Drawing.Size(682, 227);
            this.UIPanelEditUser.TabIndex = 36;
            this.UIPanelEditUser.Visible = false;
            // 
            // UIEditUserConfirm
            // 
            this.UIEditUserConfirm.BackColor = System.Drawing.Color.LimeGreen;
            this.UIEditUserConfirm.FlatAppearance.BorderSize = 0;
            this.UIEditUserConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UIEditUserConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UIEditUserConfirm.Location = new System.Drawing.Point(558, 186);
            this.UIEditUserConfirm.Name = "UIEditUserConfirm";
            this.UIEditUserConfirm.Size = new System.Drawing.Size(119, 36);
            this.UIEditUserConfirm.TabIndex = 32;
            this.UIEditUserConfirm.Text = "Confirm";
            this.UIEditUserConfirm.UseVisualStyleBackColor = false;
            this.UIEditUserConfirm.Click += new System.EventHandler(this.UIEditUserConfirm_Click);
            // 
            // UIEditUserRank
            // 
            this.UIEditUserRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIEditUserRank.FormattingEnabled = true;
            this.UIEditUserRank.Location = new System.Drawing.Point(66, 68);
            this.UIEditUserRank.Name = "UIEditUserRank";
            this.UIEditUserRank.Size = new System.Drawing.Size(154, 28);
            this.UIEditUserRank.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(5, 68);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 20);
            this.label20.TabIndex = 30;
            this.label20.Text = "Rank :";
            // 
            // UIAdminUID
            // 
            this.UIAdminUID.AutoSize = true;
            this.UIAdminUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIAdminUID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.UIAdminUID.Location = new System.Drawing.Point(3, 35);
            this.UIAdminUID.Name = "UIAdminUID";
            this.UIAdminUID.Size = new System.Drawing.Size(82, 16);
            this.UIAdminUID.TabIndex = 29;
            this.UIAdminUID.Text = "UIAdminUID";
            // 
            // UIAdminUser
            // 
            this.UIAdminUser.AutoSize = true;
            this.UIAdminUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIAdminUser.Location = new System.Drawing.Point(3, 3);
            this.UIAdminUser.Margin = new System.Windows.Forms.Padding(3);
            this.UIAdminUser.Name = "UIAdminUser";
            this.UIAdminUser.Size = new System.Drawing.Size(176, 31);
            this.UIAdminUser.TabIndex = 28;
            this.UIAdminUser.Text = "UIAdminUser";
            // 
            // UIUsersResult
            // 
            this.UIUsersResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.UIUsersResult.FormattingEnabled = true;
            this.UIUsersResult.ItemHeight = 25;
            this.UIUsersResult.Location = new System.Drawing.Point(22, 141);
            this.UIUsersResult.Name = "UIUsersResult";
            this.UIUsersResult.Size = new System.Drawing.Size(682, 179);
            this.UIUsersResult.TabIndex = 35;
            this.UIUsersResult.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UIUsersResult_MouseDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(18, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 24);
            this.label19.TabIndex = 34;
            this.label19.Text = "Search";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UISearchUser
            // 
            this.UISearchUser.Location = new System.Drawing.Point(22, 94);
            this.UISearchUser.Name = "UISearchUser";
            this.UISearchUser.Size = new System.Drawing.Size(447, 32);
            this.UISearchUser.TabIndex = 33;
            this.UISearchUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UISearchUser_KeyDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(15, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 37);
            this.label18.TabIndex = 32;
            this.label18.Text = "Users";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UISettings
            // 
            this.UISettings.Controls.Add(this.hueControl1);
            this.UISettings.Controls.Add(this.label1);
            this.UISettings.Location = new System.Drawing.Point(4, 34);
            this.UISettings.Name = "UISettings";
            this.UISettings.Padding = new System.Windows.Forms.Padding(3);
            this.UISettings.Size = new System.Drawing.Size(1897, 900);
            this.UISettings.TabIndex = 7;
            this.UISettings.Text = "Settings";
            this.UISettings.UseVisualStyleBackColor = true;
            // 
            // hueControl1
            // 
            this.hueControl1.AutoSize = true;
            this.hueControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hueControl1.BackColor = System.Drawing.Color.White;
            this.hueControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hueControl1.Location = new System.Drawing.Point(13, 6);
            this.hueControl1.Name = "hueControl1";
            this.hueControl1.Size = new System.Drawing.Size(1186, 399);
            this.hueControl1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(1502, 982);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "By Malaury Dutour - 2018";
            // 
            // UIAccount
            // 
            this.UIAccount.Controls.Add(this.AccountControl);
            this.UIAccount.Location = new System.Drawing.Point(4, 34);
            this.UIAccount.Name = "UIAccount";
            this.UIAccount.Padding = new System.Windows.Forms.Padding(3);
            this.UIAccount.Size = new System.Drawing.Size(1897, 900);
            this.UIAccount.TabIndex = 6;
            this.UIAccount.Text = "Account";
            this.UIAccount.UseVisualStyleBackColor = true;
            // 
            // AccountControl
            // 
            this.AccountControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountControl.Location = new System.Drawing.Point(2, 0);
            this.AccountControl.Margin = new System.Windows.Forms.Padding(6);
            this.AccountControl.Name = "AccountControl";
            this.AccountControl.Size = new System.Drawing.Size(683, 539);
            this.AccountControl.TabIndex = 0;
            this.AccountControl.EditAccountDone += new System.EventHandler<Musics___Client.API.Events.EditAccountEventArgs>(this.AccountControl_EditAccountDone);
            // 
            // UIFavorites
            // 
            this.UIFavorites.Controls.Add(this.FavoriteControl);
            this.UIFavorites.Location = new System.Drawing.Point(4, 34);
            this.UIFavorites.Name = "UIFavorites";
            this.UIFavorites.Padding = new System.Windows.Forms.Padding(3);
            this.UIFavorites.Size = new System.Drawing.Size(1897, 900);
            this.UIFavorites.TabIndex = 3;
            this.UIFavorites.Text = "Favorites";
            this.UIFavorites.UseVisualStyleBackColor = true;
            // 
            // FavoriteControl
            // 
            this.FavoriteControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavoriteControl.Location = new System.Drawing.Point(-1, 0);
            this.FavoriteControl.Margin = new System.Windows.Forms.Padding(6);
            this.FavoriteControl.Name = "FavoriteControl";
            this.FavoriteControl.Size = new System.Drawing.Size(1193, 361);
            this.FavoriteControl.TabIndex = 0;
            this.FavoriteControl.SearchEvent += new System.EventHandler<Musics___Client.API.Events.RequestBinairiesEventArgs>(this.FavoriteControl_SearchEvent);
            this.FavoriteControl.PlayAllEvent += new System.EventHandler<Musics___Client.API.Events.PlayEventArgs>(this.FavoriteControl_PlayAllEvent);
            // 
            // UISearch
            // 
            this.UISearch.Controls.Add(this.SearchControl);
            this.UISearch.Location = new System.Drawing.Point(4, 34);
            this.UISearch.Name = "UISearch";
            this.UISearch.Padding = new System.Windows.Forms.Padding(3);
            this.UISearch.Size = new System.Drawing.Size(1897, 900);
            this.UISearch.TabIndex = 1;
            this.UISearch.Text = "Search";
            this.UISearch.UseVisualStyleBackColor = true;
            // 
            // SearchControl
            // 
            this.SearchControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchControl.Location = new System.Drawing.Point(-7, -2);
            this.SearchControl.Name = "SearchControl";
            this.SearchControl.Size = new System.Drawing.Size(1901, 897);
            this.SearchControl.TabIndex = 0;
            this.SearchControl.SearchEvent += new System.EventHandler<Musics___Client.API.Events.SearchEventArgs>(this.SearchControl_SearchEvent);
            this.SearchControl.ClearEvent += new System.EventHandler<System.EventArgs>(this.SearchControl_ClearEvent);
            this.SearchControl.UploadEvent += new System.EventHandler<System.EventArgs>(this.SearchControl_UploadEvent);
            this.SearchControl.PlayEvent += new System.EventHandler<Musics___Client.API.Events.PlayEventArgs>(this.SearchControl_PlayEvent);
            this.SearchControl.AddPlaylistEvent += new System.EventHandler<System.EventArgs>(this.SearchControl_AddPlaylistEvent);
            this.SearchControl.RateEvent += new System.EventHandler<Musics___Client.API.Events.RateEventArgs>(this.SearchControl_RateEvent);
            this.SearchControl.PathClicked += new System.EventHandler<Musics___Client.API.Events.PathClickedEventArgs>(this.SearchControl_PathClicked);
            this.SearchControl.EditMusic += new System.EventHandler<Musics___Client.API.Events.EditMusicEventArgs>(this.SearchControl_EditMusic);
            this.SearchControl.PlaylistSaved += new System.EventHandler<Musics___Client.API.Events.PlaylistSavedEventArgs>(this.SearchControl_PlaylistSaved);
            // 
            // UIHome
            // 
            this.UIHome.BackColor = System.Drawing.Color.White;
            this.UIHome.Controls.Add(this.homeControl1);
            this.UIHome.Location = new System.Drawing.Point(4, 34);
            this.UIHome.Name = "UIHome";
            this.UIHome.Padding = new System.Windows.Forms.Padding(3);
            this.UIHome.Size = new System.Drawing.Size(1897, 900);
            this.UIHome.TabIndex = 0;
            this.UIHome.Text = "Home";
            // 
            // homeControl1
            // 
            this.homeControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeControl1.Location = new System.Drawing.Point(542, 9);
            this.homeControl1.Margin = new System.Windows.Forms.Padding(6);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(813, 514);
            this.homeControl1.TabIndex = 0;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.UIHome);
            this.Tabs.Controls.Add(this.UISearch);
            this.Tabs.Controls.Add(this.UIFavorites);
            this.Tabs.Controls.Add(this.UIAccount);
            this.Tabs.Controls.Add(this.UISettings);
            this.Tabs.Controls.Add(this.UIAdministration);
            this.Tabs.Controls.Add(this.tabPage3);
            this.Tabs.Font = new System.Drawing.Font("Raleway Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabs.ItemSize = new System.Drawing.Size(90, 30);
            this.Tabs.Location = new System.Drawing.Point(-1, 0);
            this.Tabs.Multiline = true;
            this.Tabs.Name = "Tabs";
            this.Tabs.Padding = new System.Drawing.Point(20, 3);
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1905, 938);
            this.Tabs.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.UITracker);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1897, 900);
            this.tabPage3.TabIndex = 9;
            this.tabPage3.Text = "Trackers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // UITracker
            // 
            this.UITracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UITracker.Location = new System.Drawing.Point(0, 0);
            this.UITracker.Margin = new System.Windows.Forms.Padding(6);
            this.UITracker.Name = "UITracker";
            this.UITracker.Size = new System.Drawing.Size(1901, 897);
            this.UITracker.TabIndex = 0;
            this.UITracker.UIAddTracker += new System.EventHandler<Musics___Client.API.Events.AddingTrackerEventArgs>(this.UITracker_UIAddTracker);
            this.UITracker.UIRemoveTracker += new System.EventHandler<Musics___Client.API.Events.AddingTrackerEventArgs>(this.UITracker_UIRemoveTracker);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 1041);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // uPlayer1
            // 
            this.uPlayer1.BackColor = System.Drawing.Color.White;
            this.uPlayer1.Location = new System.Drawing.Point(0, 935);
            this.uPlayer1.Name = "uPlayer1";
            this.uPlayer1.Size = new System.Drawing.Size(1904, 106);
            this.uPlayer1.TabIndex = 2;
            this.uPlayer1.RequestBinairies += new System.EventHandler<ControlLibrary.MusicUtils.Event.OnRequestBinairiesEventArgs>(this.uPlayer1_RequestBinairies);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.uPlayer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Client";
            this.Text = "Musics - Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            this.UIAdministration.ResumeLayout(false);
            this.UIAdministration.PerformLayout();
            this.UIPanelEditUser.ResumeLayout(false);
            this.UIPanelEditUser.PerformLayout();
            this.UISettings.ResumeLayout(false);
            this.UISettings.PerformLayout();
            this.UIAccount.ResumeLayout(false);
            this.UIFavorites.ResumeLayout(false);
            this.UISearch.ResumeLayout(false);
            this.UIHome.ResumeLayout(false);
            this.Tabs.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer HueTimer;
        private System.Windows.Forms.TabPage UIAdministration;
        private System.Windows.Forms.Panel UIPanelEditUser;
        private System.Windows.Forms.Button UIEditUserConfirm;
        private System.Windows.Forms.ComboBox UIEditUserRank;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label UIAdminUID;
        private System.Windows.Forms.Label UIAdminUser;
        private System.Windows.Forms.ListBox UIUsersResult;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox UISearchUser;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage UISettings;
        private System.Windows.Forms.TabPage UIAccount;
        private System.Windows.Forms.TabPage UIFavorites;
        private System.Windows.Forms.TabPage UISearch;
        private System.Windows.Forms.TabPage UIHome;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private UI.HomeControl homeControl1;
        private UI.SearchControl SearchControl;
        private UI.FavoriteControl FavoriteControl;
        private UI.AccountControl AccountControl;
        private ControlLibrary.User_Interface.HueControl hueControl1;
        private System.Windows.Forms.Splitter splitter1;
        private ControlLibrary.UPlayer uPlayer1;
        private System.Windows.Forms.TabPage tabPage3;
        private UI.TrackerControl UITracker;
        private System.Windows.Forms.ComboBox UIAdministrationServers;
    }
}

