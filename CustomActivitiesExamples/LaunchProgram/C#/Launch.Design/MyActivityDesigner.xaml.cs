namespace LaunchProgramActivity.Design
{

    using System.Activities.Presentation.Metadata;
    using System.ComponentModel;
    using System.Drawing;

    /// <summary>
    /// The MyActivity designer.
    /// </summary>
    public partial class MyActivityDesigner2
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MyActivityDesigner2"/> class.
        /// </summary>
        public MyActivityDesigner2()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Registers metadata.
        /// </summary>
        /// <param name="builder">
        /// The builder.
        /// </param>
    public static void RegisterMetadata(AttributeTableBuilder builder)
    {
        builder.AddCustomAttributes(
            typeof(LaunchProgram), 
            new DesignerAttribute(typeof(MyActivityDesigner2)), 
            new DescriptionAttribute("Launch a Program with specific root"), 
            new ToolboxBitmapAttribute(typeof(LaunchProgram), "PlayButton.png"));
    }

        #endregion
    }
}