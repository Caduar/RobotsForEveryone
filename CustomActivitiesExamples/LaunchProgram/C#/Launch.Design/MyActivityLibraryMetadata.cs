
namespace LaunchProgramActivity.Design
{
    using System.Activities.Presentation.Metadata;

    /// <summary>
    /// Designer Metadata registration support
    /// </summary>
    public sealed class MyActivityLibraryMetadata2 : IRegisterMetadata
    {
        #region Public Methods

        /// <summary>
        /// Registers metadata
        /// </summary>
        public static void RegisterAll()
        {
            var builder = new AttributeTableBuilder();
            MyActivityDesigner2.RegisterMetadata(builder);

            // TODO: Other activities can be added here
            MetadataStore.AddAttributeTable(builder.CreateTable());
        }

        /// <summary>
        /// Registers metadata
        /// </summary>
        public void Register()
        {
            RegisterAll();
        }

        #endregion
    }
}