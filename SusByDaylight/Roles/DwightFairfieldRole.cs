using MiraAPI.Roles;
using UnityEngine; // Added to resolve the 'Color' error
// using MiraAPI; // Uncomment or adjust this if 'Palette' or 'ImpostorRole' are in a different MiraAPI namespace

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SusByDaylight.Roles
{
    // Removed the outer 'internal class' wrapper that was causing the naming conflict
    public class DwightFairfieldRole : ImpostorRole, ICustomRole
    {
        public string RoleName => "Dwight Fairfield";
        public string RoleLongDescription => "A nervous leader who excels at group coordination, gaining significant task-speed boosts whenever he works in close proximity to other crewmates.";
        public string RoleDescription => RoleLongDescription;

        public Color RoleColor => Palette.ImpostorRed;
        public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;

        public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
        {
            MaxRoleCount = 1,
        };
    }
}