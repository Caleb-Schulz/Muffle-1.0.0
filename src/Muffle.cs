using Vintagestory.API.Client;
using Vintagestory.API.Common;

namespace Muffle
{
    public class Muffle : ModSystem
    {
        private MuffleGui myMuffleGui;
        private ICoreClientAPI capi;

        public override bool ShouldLoad(EnumAppSide side)
        {
            return side == EnumAppSide.Client;
        }

        public override void StartClientSide(ICoreClientAPI capi)
        {
            this.capi = capi;

            // Registering 'P' as the default key
            capi.Input.RegisterHotKey("mufflemenu", "Open Muffle: Audio Mixer", GlKeys.P, HotKeyType.GUIOrEverything);

            capi.Input.SetHotKeyHandler("mufflemenu", OnMuffleMenuPressed);
        }

        private bool OnMuffleMenuPressed(KeyCombination comb)
        {
            if (myMuffleGui == null)
            {
                myMuffleGui = new MuffleGui(capi);
            }

            if (myMuffleGui.IsOpened())
            {
                return myMuffleGui.TryClose();
            }
            else
            {
                return myMuffleGui.TryOpen();
            }
        }
    }
}