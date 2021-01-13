﻿/*
 * MIT License
 *
 * Copyright(c) 2019 KeLi
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

/*
             ,---------------------------------------------------,              ,---------,
        ,----------------------------------------------------------,          ,"        ,"|
      ,"                                                         ,"|        ,"        ,"  |
     +----------------------------------------------------------+  |      ,"        ,"    |
     |  .----------------------------------------------------.  |  |     +---------+      |
     |  | C:\>FILE -INFO                                     |  |  |     | -==----'|      |
     |  |                                                    |  |  |     |         |      |
     |  |                                                    |  |  |/----|`---=    |      |
     |  |              Author: KeLi                          |  |  |     |         |      |
     |  |              Email: kelicto@protonmail.com         |  |  |     |         |      |
     |  |              Creation Time: 11/23/2019 03:28:10 PM |  |  |     |         |      |
     |  | C:\>_                                              |  |  |     | -==----'|      |
     |  |                                                    |  |  |   ,/|==== ooo |      ;
     |  |                                                    |  |  |  // |(((( [66]|    ,"
     |  `----------------------------------------------------'  |," .;'| |((((     |  ,"
     +----------------------------------------------------------+  ;;  | |         |,"
        /_)_________________________________________________(_/  //'   | +---------+
           ___________________________/___  `,
          /  oooooooooooooooo  .o.  oooo /,   \,"-----------
         / ==ooooooooooooooo==.o.  ooo= //   ,`\--{)B     ,"
        /_==__==========__==_ooo__ooo=_/'   /___________,"
*/

using System.ComponentModel;

namespace KeLi.GameComps.Parts
{
    public partial class FurnishSuitCtrl : GameCtrl
    {
        public FurnishSuitCtrl()
        {
            InitializeComponent();
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string SuitName
        {
            get => lblSuitName.Text;
            set => lblSuitName.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string Mark
        {
            get => lblMark.Text;
            set => lblMark.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string Shoe
        {
            get => lblShoe.Text;
            set => lblShoe.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string Handguard
        {
            get => lblHandguard.Text;
            set => lblHandguard.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string Belt
        {
            get => lblBelt.Text;
            set => lblBelt.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string Cloth
        {
            get => lblCloth.Text;
            set => lblCloth.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string Necklace
        {
            get => lblNecklace.Text;
            set => lblNecklace.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string Ring
        {
            get => lblRing.Text;
            set => lblRing.Text = value;
        }
    }
}