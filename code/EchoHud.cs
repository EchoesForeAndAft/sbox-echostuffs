using Sandbox.UI;

//
// You don't need to put things in a namespace, but it doesn't hurt.
//
namespace EchoStuffs
{
	/// <summary>
	/// This is the HUD entity. It creates a RootPanel clientside, which can be accessed
	/// via RootPanel on this entity, or Local.Hud.
	/// </summary>
	public partial class EchoHudEntity : Sandbox.HudEntity<RootPanel>
	{
		public EchoHudEntity()
		{
			if ( IsClient )
			{
				RootPanel.SetTemplate( "/ui/EchoHud.html" );
			}
		}
	}

}
