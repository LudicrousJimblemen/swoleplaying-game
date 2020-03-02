using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeObject : InteractableWorldObject {
    private string[] messages = {
        "You rap your knuckles against the tree trunk; it sounds oddly musical.",
        "You could probably grab some fruit from this tree if your legs weren't so stubby and nonexistent.",
        "You take a moment to admire the leaves. They're... full of color.",
        "You ponder the possibilities this wood gives you. You could make a small canoe, or maybe 60 to 70 Dala Horses.",
        "The tree calls to you."
    };
    public override void OnInteract(WorldActor interactor) {
        print(messages[Random.Range(0, messages.Length)]);
    }
}
