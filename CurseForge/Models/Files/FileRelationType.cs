namespace CurseForge.Models.Files;

public enum FileRelationType
{
    EmbeddedLibrary = 1,
    OptionalDependency,
    RequiredDependency,
    Tool,
    Incompatible,
    Include
}