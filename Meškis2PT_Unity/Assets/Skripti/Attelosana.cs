using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attelosana : MonoBehaviour {
	public GameObject DiamondHelm, DiamondChest, DiamondPants, DiamondBoots, IronHelm, IronChest, IronPants, IronBoots, GoldHelm, GoldChest, GoldPants, GoldBoots, LeatherHelm, LeatherChest, LeatherPants, LeatherBoots;
	public void HelmetAttelosana(bool vertiba){
		DiamondHelm.SetActive(vertiba);
		IronHelm.SetActive(vertiba);
		GoldHelm.SetActive(vertiba);
		LeatherHelm.SetActive(vertiba);
	}
	public void ChestAttelosana(bool vertiba){
		DiamondChest.SetActive(vertiba);
		IronChest.SetActive(vertiba);
		GoldChest.SetActive(vertiba);
		LeatherChest.SetActive(vertiba);
	}
	public void PantsAttelosana(bool vertiba){
		DiamondPants.SetActive(vertiba);
		IronPants.SetActive(vertiba);
		GoldPants.SetActive(vertiba);
		LeatherPants.SetActive(vertiba);
	}

	public void BootsAttelosana(bool vertiba){
		DiamondBoots.SetActive(vertiba);
		IronBoots.SetActive(vertiba);
		GoldBoots.SetActive(vertiba);
		LeatherBoots.SetActive(vertiba);
	}

}
