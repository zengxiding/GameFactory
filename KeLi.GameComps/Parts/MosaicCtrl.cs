﻿using System.ComponentModel;

namespace KeLi.GameComps.Parts
{
    public partial class MosaicCtrl : GameCtrl
    {
        public MosaicCtrl()
        {
            InitializeComponent();
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string MosaicName
        {
            get => lblMosaicName.Text;
            set => lblMosaicName.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string FirstProperty
        {
            get => lblFirstProperty.Text;
            set => lblFirstProperty.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string SecondProperty
        {
            get => lblSecondProperty.Text;
            set => lblSecondProperty.Text = value;
        }
    }
}