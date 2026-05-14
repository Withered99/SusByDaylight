using MiraAPI.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SusByDaylight.Roles
{
    internal class EvanMacMillanRole
    {
        public class EvanMacMillanRole : ImpostorRole, ICustomRole
        {
            public string RoleName => "Evan MacMillan";
            public string RoleLongDescription => "Control the map by placing hidden bear traps in high-traffic areas.";
            public string RoleDescription => RoleLongDescription;
            public Color RoleColor => Palette.ImposterRed;
            public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;

            public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
            {
                MaxRoleCount = 2,
            };
        }
    }
}
