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
    public class EvanMacMillanRole : ImpostorRole, ICustomRole
    {
        public string RoleName => "Evan MacMillan";
        public string RoleLongDescription => "Control the map by placing hidden bear traps in high-traffic areas.";
        public string RoleDescription => RoleLongDescription;

        public Color RoleColor => Palette.ImpostorRed;
        public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;

        public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
        {
            MaxRoleCount = 2,
        };
    }
}