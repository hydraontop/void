﻿using System;
using System.Windows.Forms;
using Void.ClientBase;
using Void.ClientBase.KeyBase;
using Void.ClientBase.VersionBase;
using Void.Modules.vModuleExtra;

namespace Void.Modules
{
    internal class LongJump : Module
    {

        public LongJump() : base("LongJump", (char)0x07, "Player")
        {
            addBypass(new BypassBox(new string[] { "Default", "Hive" }));
        } // Not defined+-/9*9
        public override void OnEnable()
        {
            MCM.writeFloat(Game.localPlayer + VersionClass.GetData("velocity") + 4, 0.5f);
            base.OnEnable();
        }
        public override void OnTick()
        {
            Vector3 newVel = Game.velocity;

            if (newVel.y > 0)
            {
                if (Game.onGround == false)
                {
                    newVel.x *= 1.1f;
                    newVel.y *= 1.06f;
                    newVel.z *= 1.1f;
                }
            }

            Game.velocity = newVel;
        }
    }
}
