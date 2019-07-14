# MakeLobbiesEvenBetter
[![Build Status](https://travis-ci.org/Piggered/MakeLobbiesEvenBetter.svg?branch=master)](https://travis-ci.org/Piggered/MakeLobbiesEvenBetter) [![Repository Issues](https://img.shields.io/github/issues/Piggered/MakeLobbiesEvenBetter.svg)](https://github.com/Piggered/MakeLobbiesEvenBetter/issues) [![Repository License](https://img.shields.io/github/license/Piggered/MakeLobbiesEvenBetter.svg)](https://github.com/Piggered/MakeLobbiesEvenBetter/blob/master/LICENSE)

*Make Lobbies Even Better* (abbreviated *MLEB*) is a program that shows the host's Steam profile on Dead by Daylight. It uses the game's log files in order to fetch the host, then gets the profile info directly from Steam's website.

![Preview of the program](https://raw.githubusercontent.com/Piggered/MakeLobbiesEvenBetter/master/preview.png)

### [Download Make Lobbies Even Better for Windows](https://github.com/Piggered/MakeLobbiesEvenBetter/releases)

## Program Requirements

* Windows 7 OS or later (8, 8.1, 10);
* [.NET Framework 4.7](https://www.microsoft.com/en-us/download/details.aspx?id=55170) or later;
* [Dead by Daylight](https://store.steampowered.com/app/381210/Dead_by_Daylight/) on Steam.

## Key Features of Make Lobbies Even Better

* See who is the lobby host's Steam profile<sup>**[1]**</sup> as you join a lobby.
* Remember which killers are @$$holes by binding the host to a personal note.
* Get notified whenever you join a lobby in which the host is bound to a personal note.
* Forcibly close/kill the game in case you’ve been *BHVR*'d<sup>**[2]**</sup>.
* Don't want to see the killer's profile? You can change that in the Toolbox<sup>**[3]**</sup>!

<sup>**[1]**</sup> Lobby hosts consist of the following: The SWF lobby starter, the KYF host or the killer in a normal lobby.  
<sup>**[2]**</sup> *BHVR*'d: Whenever a game by *Behaviour Interactive* freezes or crashes for no reason.  
<sup>**[3]**</sup> Other options and settings are available in the *Toolbox*.

This program **does not** show the host's ping like [MLGA](https://github.com/PsiLupan/MakeLobbiesGreatAgain) does. If desired, you may run both programs at the same time.

The program also does not work as the lobby host (killer, KYF host, etc.) due to design limitations.

## This Program Is Not Bannable

This program is **NOT** detected by EAC. All it does (related to the game) is read the game's log files in order to acquire a Steam ID. *MLEB* **does not** tamper with the game in any way.

The game's log files can be easily accessed at: `%localappdata%\DeadByDaylight\Saved\Logs`.

## Managing Notifications on Noted Host

If you wish to replace the notification sound, you may do so by replacing `Notification.wav`. Your custom sound must be in WAV format and must be exactly named `Notification.wav`.

If you wish to not use a notification sound, but wish to keep the notifcation flashing on your taskbar, you may simply delete `Notification.wav` (or rename it to something else).

If you wish to disable to notification feature altogether, you may turn it off in the *Toolbox*.

## Program Not Working Properly?

* If the program is stuck to one profile, you may have forgotten to save or cancel the note you're editing.
* If the program is showing a random profile, remember that the program simply reads the latest host you had.
* If none of the above apply, reload the reader by using the "Force Reload" button in the *Toolbox*. If it's still not working properly after reloading, restart the program entirely.

## Questions and Issues

If you have any questions or issues, please post a new issue [here](https://github.com/Piggered/MakeLobbiesEvenBetter/issues/new) and label it accordingly.

Be sure to check if [your issue isn't already posted](https://github.com/Piggered/MakeLobbiesEvenBetter/issues) by someone else.
