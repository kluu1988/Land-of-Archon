
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class DrkBlueCornerChairAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DrkBlueCornerChairAddonDeed();
			}
		}

		[ Constructable ]
		public DrkBlueCornerChairAddon()
		{



			AddComplexComponent( (BaseAddon) this, 5692, 0, 1, 5, 101, -1, "A Pillow", 1);// 1
			AddComplexComponent( (BaseAddon) this, 5692, 1, 0, 5, 101, -1, "A Pillow", 1);// 2
			AddComplexComponent( (BaseAddon) this, 5690, 0, 0, 5, 101, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2861, 1, 1, 0, 3, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1848, 0, 1, 0, 3, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1848, 1, 0, 0, 3, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1848, 0, 0, 0, 3, -1, "", 1);// 7

		}

		public DrkBlueCornerChairAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class DrkBlueCornerChairAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DrkBlueCornerChairAddon();
			}
		}

		[Constructable]
		public DrkBlueCornerChairAddonDeed()
		{
			Name = "DrkBlueCornerChair";
		}

		public DrkBlueCornerChairAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}