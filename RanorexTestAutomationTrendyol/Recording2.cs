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
    ///The Recording2 recording.
    /// </summary>
    [TestModule("829b7e1f-fab7-4574-a672-748f9021d86f", ModuleType.Recording, 1)]
    public partial class Recording2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RanorexTestAutomationTrendyolRepository repository.
        /// </summary>
        public static RanorexTestAutomationTrendyolRepository repo = RanorexTestAutomationTrendyolRepository.Instance;

        static Recording2 instance = new Recording2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording2 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AccountNavigationWrapper.GirişYap' at 15;8.", repo.ApplicationUnderTest.AccountNavigationWrapper.GirişYapInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.AccountNavigationWrapper.GirişYap.Click("15;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LoginEmail' at 38;25.", repo.ApplicationUnderTest.LoginEmailInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.LoginEmail.Click("38;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'zeynepakin10{RMenu down}' with focus on 'ApplicationUnderTest.LoginEmail'.", repo.ApplicationUnderTest.LoginEmailInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.LoginEmail.PressKeys("zeynepakin10{RMenu down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+Alt+Q' Press with focus on 'ApplicationUnderTest.LoginEmail'.", repo.ApplicationUnderTest.LoginEmailInfo, new RecordItemIndex(3));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.LoginEmail);
            Keyboard.Press(System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt, 16, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey up}{RMenu up}{Gkey}mail.com' with focus on 'ApplicationUnderTest.LoginEmail'.", repo.ApplicationUnderTest.LoginEmailInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.LoginEmail.PressKeys("{LControlKey up}{RMenu up}{Gkey}mail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LoginRegister.GirişYap' at 12;13.", repo.ApplicationUnderTest.LoginRegister.GirişYapInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.LoginRegister.GirişYap.Click("12;13");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
