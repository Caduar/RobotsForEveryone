
namespace LaunchProgramActivity
{
    using System.Drawing;
    using System.Activities;
    using System.ComponentModel;
    using FlaUI.UIA3;


    /// <summary>
    /// MyActivity is a sample to show you how to create the designer
    /// </summary>
    /// <remarks>
    /// TODO: Be sure the build action for your bitmap is set to Embedded Resource 
    ///   NOTE: The bitmap must be at the same location as the class
    ///   NOTE: If you use ToolboxBitmap here your activity assembly and those who use it will have to reference System.Drawing
    ///   Instead you can add the ToolboxBitmapAttribute when you register the metadata to avoid this.
       [ToolboxBitmap(typeof(LaunchProgram), "PlayButton.png")]
   

    /// </remarks>
    public sealed class LaunchProgram : NativeActivity
{
        #region Public Properties

        [Category("Input")]
        public InArgument<string> ProgramDirectory { get; set; }

        [Category("Output")]
        public OutArgument<string> NombreDeLaVentana { get; set; }

        [Category("Output")]
        public OutArgument<FlaUI.Core.AutomationElements.Window> Ventana { get; set; }


        #endregion

        #region Methods

        /// <summary>
        /// The execute.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        protected override void Execute(NativeActivityContext context)
        {
            var ruta = context.GetValue(this.ProgramDirectory);
            var app = FlaUI.Core.Application.Launch(ruta);
            using (var automation = new UIA3Automation())
            {
                var window = app.GetMainWindow(automation);
                var capturando = window.Title.ToString();
                var ventanaCapturada = window;

                NombreDeLaVentana.Set(context, capturando);
                Ventana.Set(context, ventanaCapturada);
               
            }
        }

        #endregion
    }
}