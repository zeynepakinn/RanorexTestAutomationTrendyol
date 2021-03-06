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
    ///The Recording4 recording.
    /// </summary>
    [TestModule("6e5aceac-9b02-47e3-98ac-366de8e25d08", ModuleType.Recording, 1)]
    public partial class Recording4 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RanorexTestAutomationTrendyolRepository repository.
        /// </summary>
        public static RanorexTestAutomationTrendyolRepository repo = RanorexTestAutomationTrendyolRepository.Instance;

        static Recording4 instance = new Recording4();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording4()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording4 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TrendyolCollectionYeniSezonFırsatl' at 290;102.", repo.ApplicationUnderTest.TrendyolCollectionYeniSezonFırsatlInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.TrendyolCollectionYeniSezonFırsatl.Click("290;102");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ProductBrandDescriptionTwoLineText' at 187;22.", repo.ApplicationUnderTest.ProductBrandDescriptionTwoLineTextInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.ProductBrandDescriptionTwoLineText.Click("187;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SepeteEkle' at 232;16.", repo.ApplicationUnderTest.SepeteEkleInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.SepeteEkle.Click("232;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CokRenkli4luePaketOErmeCorapTWOSS2' at 166;13.", repo.ApplicationUnderTest.CokRenkli4luePaketOErmeCorapTWOSS2Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.CokRenkli4luePaketOErmeCorapTWOSS2.Click("166;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SepeteEkle' at 229;16.", repo.ApplicationUnderTest.SepeteEkleInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.SepeteEkle.Click("229;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Sepetim' at 23;15.", repo.ApplicationUnderTest.SepetimInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Sepetim.Click("23;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PbContainer.SepetiOnayla' at 55;10.", repo.ApplicationUnderTest.PbContainer.SepetiOnaylaInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.PbContainer.SepetiOnayla.Click("55;10");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
