# Projet_IF37 : MobiliVRse

**Semestre :** A21

**Membres du groupe :** Maxence JAULIN, Nicolas MORAIS, Thibault PAVEE, Pauline POMAS

Document rédigé par Maxence JAULIN.



## **Description**

Ce projet a été réalisé dans le cadre de l'UE IF37 "Conception responsable de systèmes interactifs" pour l'Université de Technologie de Troyes. L'objectif de ce projet est de permettre de répondre à la problématique suivante : Comment permettre d'améliorer l’accessibilité des espaces aux personnes éloignées géographiquement en conservant une immersion importante ?

Le dépôt GIT HUB est un outil de stockage du projet permettant de contenir toutes les applets développés et les codes utilisés.



## **Installation**

Afin de disposer de la solution réalisée, il faut tout d'abord configurer la **Raspberry Pi 4** en installant le système d'exploitation dessus (OS). Il faut que la Raspberry Pi soit connectée sur le même réseau que votre ordianteur. Dans notre cas, nous avons utilisé notre téléphone portable pour faire la jonction entre les deux objets. 

Ensuite plusieurs modules indépendants sont à installer dessus avant de pouvoir exécuter les commandes pour le déplacement du module mais également du lancement du stream. Nous avons utilisé PuTTY pour communiquer en SSH avec le module sur le port 22 et réaliser les installations.


### Module de déplacement

Pour notre projet, nous avons reçu un module de déplacement contrôlable avec une Raspberry Pi. Nous n'allons pas revenir sur le montage du robot (expliqué dans le User Manual disponible dans le ./doc/picar-4wd du dépôt GIT) mais seulement sur la partie configuration de l'application sur la Raspberry.

Le modèle du robot est le suivant : **Picar-4wd** de chez Sunfounder.

Après installation de l'OS sur une carte micro SD, placez la carte dans la Raspberry puis tapez les commandes suivantes pour installer le programme de contrôle du robot depuis le dossier ./home/pi :

	$ cd /home/pi
	$ git clone https://github.com/sunfounder/picar-4wd

Entrez ensuite dans le dossier ./home/pi/picar-4wd.

	$ cd /home/pi/picar-4wd/
	$ sudo python3 setup.py install

L'installation du module de déplacement est finalisé après cette étape. Pour plus d'informations, le manuel d'utilisation rédigé par Sunfounder donne plus de détails sur l'installation de celui-ci.


### Module de streaming

Nous avons également conçu un module permettant de pouvoir streamer le flux vidéo d'une caméra (Caméra 360° **Ricoh Theta S**) sur la Raspberry Pi. Pour se faire, nous avons utilisé **MJPG-Streamer** car c'était, selon de nombreuses comparaison, le streamer qui avait le meilleur rapport qualité de l'image, images par seconde et latence... Des caractéristiques très importantes dans ce genre de projet où une diffusion streaming est attendue.

Pour installer le module nous avons procédé de la façon suivante :

	$ git clone https://github.com/jacksonliam/mjpg-streamer
	$ sudo apt-get install cmake libjpeg9-dev
	$ sudo apt-get install gcc g++

Entrez ensuite dans le dossier ./home/pi/mjpg-streamer/mjpg-streamer-experimental.

	$ cd mjpg-streamer/mjpg-streamer-experimental
	$ make
	$ sudo make install

L'installation du module de streaming en local est finalisé après cette étape. Pour plus d'informations, la vidéo de John Lee explique bien le déroulement (cf ./doc/Liens_utiles_à_consulter_MobiliVRse.pdf).


### Module VR

Pour la partie VR du projet, nous avons réalisé une application sur Unity faisant office de player de vidéo 360° pour permettre de lire le flux vidéo sur un casque de réalité virtuelle de type **Oculus Rift S**. L'application est disponible dans le dossier associé depuis la racine du dépôt GIT.



## **Exécution**

Après installation des modules, il ne reste plus qu'à les lancer... Avant tout connectez vous sur la Raspberry en SSH via PuTTY. Ouvrez plusieurs terminaux afin de pouvoir exécuter plusieurs commandes simultanément (avantage de la communication en SSH). Suivez ensuite les instructions ci-dessous pour le lancement de chaque module.


### Module de déplacement

Avant tout chose, il faut avoir connecté la carte moteur **4wd-hat** sur les pins de la **Raspberry**. Ensuite il faut fournir à la Raspberry Pi une alimentation nécessaire via la carte moteur et les accumulateurs fournissant de l'énergie. Pour les accumulateurs électriques, nous avons utilisé les cellules NCR 18650 de 3.7V.

Placez vous dans le dossier ./home/pi/picar-4wd pour exécuter la commande.

	$ cd /home/pi/picar-4wd/
	$ picar-4wd web-example

Connectez vous sur l'ip locale de votre Raspberry Pi. Vous pouvez controler le robot depuis votre téléphone par exemple.


### Module de streaming

Avant toute chose, il faut brancher la caméra sur un des ports USB de la Raspberry Pi.

Placez vous ensuite dans le dossier ./home/pi/mjpg-streamer/mjpg-streamer-experimental

	$ cd /home/pi/mjpg-streamer/mjpg-streamer-experimental
	$ /usr/local/bin/mjpg_streamer -i "input_uvc.so -r 640x480 -d /dev/video0 -f 24 -q 80" -o "output_http.so -p 8080 -w /usr/local/share/mjpg-streamer/www"

Connectez vous ensuite sur l'ip locale de votre Raspberry Pi. Vous deverez rajouter le port de communication, ici nous utilisons le 8080.

	**Exemple :** 192.168.10.200:8080


### Module VR

Il vous suffit simplement de connecter le PC à un casque de réalité virtuelle et de lancer l'application (MobiliVRse Video Manager - Unity Build/MobiliVRse.exe). **Attention tout de même avec la compatibilité du casque VR, cette solution peut ne pas supporter des modèles différents de l'Oculus Rift S**.



## **Version**

### 1.0.0
- Ajout d'un README.md.
- Ajout des différents modules.
- Correction et mise à jour de certains modules.

### 0.0.0
- Implémentation des modules.
- Ouverture du GIT.
- Test sur plusieurs solutions pour le streaming vidéo (Gstreamer, Motion...).


## **Contexte**

Ce projet a été réalisé dans le cadre d'un cours sur la conception de systèmes interactifs ([IF37](https://moodle.utt.fr/course/view.php?id=2184)) animé par Mme. Di Loreto à [l 'Université de Technologie de Troyes (UTT)](https://www.utt.fr).


## **Copyright**

Copyright Maxence JAULIN, Thibault PAVEE, Pauline POMAS, Nicolas MORAIS