﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace RanorexTestAutomationTrendyol
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording6 recording.
    /// </summary>
    [TestModule("7ee1d7b7-ded8-4c0e-8045-3bd6ff89acf5", ModuleType.Recording, 1)]
    public partial class Recording6 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RanorexTestAutomationTrendyolRepository repository.
        /// </summary>
        public static RanorexTestAutomationTrendyolRepository repo = RanorexTestAutomationTrendyolRepository.Instance;

        static Recording6 instance = new Recording6();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording6()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording6 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TrendyolSanat' at 53;7.", repo.ApplicationUnderTest.TrendyolSanatInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.TrendyolSanat.Click("53;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Isimsizx4150x140KağıtUEzerineKurşu' at 209;21.", repo.ApplicationUnderTest.Isimsizx4150x140KağıtUEzerineKurşuInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Isimsizx4150x140KağıtUEzerineKurşu.Click("209;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SepeteEkle' at 216;8.", repo.ApplicationUnderTest.SepeteEkleInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.SepeteEkle.Click("216;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1080 units.", new RecordItemIndex(3));
            Mouse.ScrollWheel(-1080);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PrNmCt' at 200;23.", repo.ApplicationUnderTest.PrNmCtInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.PrNmCt.Click("200;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SepeteEkle' at 234;6.", repo.ApplicationUnderTest.SepeteEkleInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.SepeteEkle.Click("234;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AccountNavigationWrapper.HttpsWwwTrendyolComSepet' at 75;37.", repo.ApplicationUnderTest.AccountNavigationWrapper.HttpsWwwTrendyolComSepetInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.AccountNavigationWrapper.HttpsWwwTrendyolComSepet.Click("75;37");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PbContainer.SepetiOnayla' at 60;16.", repo.ApplicationUnderTest.PbContainer.SepetiOnaylaInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.PbContainer.SepetiOnayla.Click("60;16");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
