# PigletHunt-Beamable
The first open-source private server for the abandoned Steam game PIGGY: Hunt

This repository uses the normal Beamable API instead of locally hosting the apis like our other [repository](https://github.com/PiggyHunt/PigletHunt) does.

---

## Requirements     

Make sure you have the following installed:

- HxD [(Download)](https://mh-nexus.de/en/hxd/)
- PIGGY: Hunt Client [(Download)](https://mega.nz/folder/1qt02byb#ZxDqEQh3sZLvNCPRpeY4yw)

---

## Application Setup

* In your **PIGGY: Hunt** application folder, navigate to **piggy-hunt_Data** and open **resources.assets** in a hex editor (such as HxD). Replace **DE_1402027310012443** with your own project id, edit change_pid.py and replace the locations and project id to your one and run change_pid.py.

---

## PubNub Setup

* Go to https://pubnub.com and create your own account/login to your own account, create and grab your prototype credentials and add them into the /basic/notification.php file.

---

## Photon Setup

* Go to https://dashboard.photonengine.com and create your own account/login to your own account, check email for the account confirmation, create a new app and for **Photon SDK**, choose **Realtime**, copy app id, in your **PIGGY: Hunt** application folder, navigate to **piggy-hunt_Data** and open **resource.assets** in a hex editor (such as HxD). Replace **a34b05a1-c30c-4997-93a5-5d139a87416f** with your app id.

---

## Screenshots

<details>
  <summary>Click to view screenshots</summary>

  <img src="Screenshots/Screenshot1.png" alt="Screenshot 1">
  <img src="Screenshots/Screenshot2.png" alt="Screenshot 2">

</details>

---

## Disclaimer
**Piglet Hunt** uses resources from the APIs of **Beamable/Disruptor Beam** and is not affiliated with **MiniToon**, **Shaggy Doge**, **Beamable/Disruptor Beam**.
All rights to Piggy, Piggy: Intercity, and PIGGY: Hunt belong to their respective owners.

If a takedown is requested by the original developers, this repository will be removed.
