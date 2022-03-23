using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lobbyPlayerCards : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private GameObject waitingForPlayerPanel;
    [SerializeField] private GameObject playerDataPlayer;

    [Header("Data display")]
    [SerializeField] private Text playerDisplayNameText;
    [SerializeField] private Image selectedCharacterImage;
    [SerializeField] private Toggle isReadyToggle;
}
