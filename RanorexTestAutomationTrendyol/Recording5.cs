///////////////////////////////////////////////////////////////////////////////
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
    ///The Recording5 recording.
    /// </summary>
    [TestModule("2083ef2a-7c73-4829-b2c4-a65166a38847", ModuleType.Recording, 1)]
    public partial class Recording5 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RanorexTestAutomationTrendyolRepository repository.
        /// </summary>
        public static RanorexTestAutomationTrendyolRepository repo = RanorexTestAutomationTrendyolRepository.Instance;

        static Recording5 instance = new Recording5();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording5()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording5 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FenomenlerinKozmetikSecimleri' at 146;125.", repo.ApplicationUnderTest.FenomenlerinKozmetikSecimleriInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.FenomenlerinKozmetikSecimleri.Click("146;125");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FvrtBtn6' at 20;22.", repo.ApplicationUnderTest.FvrtBtn6Info, new RecordItemIndex(1));
            repo.ApplicationUnderTest.FvrtBtn6.Click("20;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FvrtBtn8' at 19;25.", repo.ApplicationUnderTest.FvrtBtn8Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.FvrtBtn8.Click("19;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AccountNavigationWrapper.Favorilerim' at 43;11.", repo.ApplicationUnderTest.AccountNavigationWrapper.FavorilerimInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.AccountNavigationWrapper.Favorilerim.Click("43;11");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
