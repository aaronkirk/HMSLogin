﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMSLogin.Database;

namespace HMSLogin
{
    public partial class ViewRoom : Form
    {
        HospitalMSDataContext hMS;
        public ViewRoom()
        {
            InitializeComponent();
            hMS = new HospitalMSDataContext();
            int result = hMS.tblRoomDetails.OrderByDescending(x => x.RoomId).Select(x => x.RoomId).FirstOrDefault() + 1;
            Cbx_RoomId.Text = result.ToString();
            Cbx_WardId.Items.AddRange(hMS.tblRoomDetails.Select(x => (object)x.WardId).ToArray());
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            tblRoomDetail room = new tblRoomDetail();
            room.WardId = int.Parse(Cbx_WardId.SelectedItem.ToString());
            room.RoomType = int.Parse(Cbx_RoomType.SelectedItem.ToString());
            hMS.tblRoomDetails.InsertOnSubmit(room);
            hMS.SubmitChanges();
            this.Dispose();
        }
    }
}
