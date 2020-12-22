using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIMenuSwitchingManager : MonoBehaviour
{
    public RectTransform _mainMenu,
                        _settingsMenu,
                        _navigationMenu,
                        _destinationHeader,
                        _metersUI,

                        _roomListMenu,
                        _markerDetectionMenu,
                        _systemInformationHeader,
                        _confirmScreen;

    private float animationSpeed = 0.30f; // in seconds
    //Room List
    private Vector2 mainInViewPos = new Vector2(0, -160);
    private Vector2 mainOutOfViewPos = new Vector2(0, -4000);

    private Vector2 settingsInViewPos = new Vector2(0, -560);
    private Vector2 settingsOutOfViewPos = new Vector2(0, -4000);

    private Vector2 navigationInViewPos = new Vector2(0, -260);
    private Vector2 navigationOutOfViewPos = new Vector2(0, -4000);

    private Vector2 destinationHeaderInViewPos = new Vector2(0, 1270);
    private Vector2 destinationHeaderOutOfViewPos = new Vector2(0, 4000);

    private Vector2 metersInViewPos = new Vector2(-20, -300);
    private Vector2 metersOutOfViewPos = new Vector2(-1000, 0);

    private Vector2 roomMenuInViewPos = new Vector2(20, -900);
    private Vector2 roomMenuOutOfViewPos = new Vector2(4000, 0);

    private Vector2 markerDetectionMenuInViewPos = new Vector2(0, 0);
    private Vector2 markerDetectionMenuOutOfViewPos = new Vector2(0, 4000);

    private Vector2 systemInformationInViewPos; // 200px under destinationHeader
    private Vector2 systemInformationOutOfViewPos = new Vector2(0, 4000);

    private Vector2 confirmScreenInViewPos = new Vector2(0, 0);
    private Vector2 confirmScreenOutOfViewPos = new Vector2(0, -4500);

    // Start is called before the first frame update
    void Start()
    {
        systemInformationInViewPos = destinationHeaderInViewPos - new Vector2(0, 200);
        OpenMarkerDetectionMenu();
    }

    private void CloseAllMenus()
    {
        CloseMainMenu();
        CloseSettingsMenu();
        CloseNavigationMenu();
        CloseDestinationHeader();
        CloseMarkerDetectionMenu();
        CloseConfirmScreen();
    }

    public void OpenMainMenu()
    {
        CloseAllMenus();
        _mainMenu.DOAnchorPos(mainInViewPos, animationSpeed);
    }

    private void CloseMainMenu()
    {
        _mainMenu.DOAnchorPos(mainOutOfViewPos, animationSpeed);
    }
    public void OpenSettingsMenu()
    {
        CloseAllMenus();
        _settingsMenu.DOAnchorPos(settingsInViewPos, animationSpeed);
    }

    private void CloseSettingsMenu()
    {
        _settingsMenu.DOAnchorPos(settingsOutOfViewPos, animationSpeed);
    }

    public void OpenNavigationMenu()
    {
        CloseAllMenus();
        OpenDestinationHeader();
        //_navigationMenu.DOAnchorPos(navigationInViewPos, animationSpeed);
    }

    private void CloseNavigationMenu()
    {
        _navigationMenu.DOAnchorPos(navigationOutOfViewPos, animationSpeed);
    }

    private void OpenDestinationHeader()
    {
        CloseAllMenus();
        _destinationHeader.DOAnchorPos(destinationHeaderInViewPos, animationSpeed);
        _metersUI.DOAnchorPos(metersInViewPos, animationSpeed);
        _roomListMenu.DOAnchorPos(roomMenuInViewPos, animationSpeed);
    }

    private void CloseDestinationHeader()
    {
        _destinationHeader.DOAnchorPos(destinationHeaderOutOfViewPos, animationSpeed);
        _metersUI.DOAnchorPos(metersOutOfViewPos, animationSpeed);
        _roomListMenu.DOAnchorPos(roomMenuOutOfViewPos, animationSpeed);
    }

    public void OpenMarkerDetectionMenu()
    {
        CloseAllMenus();
        _markerDetectionMenu.DOAnchorPos(markerDetectionMenuInViewPos, animationSpeed);
    }

    private void CloseMarkerDetectionMenu()
    {
        _markerDetectionMenu.DOAnchorPos(markerDetectionMenuOutOfViewPos, animationSpeed);
    }

    public void OpenSystemInformationHeader()
    {
        // Does not close all menus when called
        _systemInformationHeader.DOAnchorPos(systemInformationInViewPos, animationSpeed);
    }

    public void CloseSystemInformationHeader()
    {
        _systemInformationHeader.DOAnchorPos(systemInformationOutOfViewPos, animationSpeed);
    }

    public void OpenConfirmScreen()
    {
        CloseAllMenus();
        _confirmScreen.DOAnchorPos(confirmScreenInViewPos, animationSpeed);
    }

    private void CloseConfirmScreen()
    {
        _confirmScreen.DOAnchorPos(confirmScreenOutOfViewPos, animationSpeed);
    }
}
