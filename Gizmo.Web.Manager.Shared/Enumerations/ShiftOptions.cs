using System;

namespace Gizmo.Web.Manager.Shared
{
    [Flags]
    public enum ShiftStartOptions
    {
        None = 0,
        Skip = 1,
        StartNewShift = 2,
        UseActiveShift = 4,
        EndActiveShift = 8
    }
}
