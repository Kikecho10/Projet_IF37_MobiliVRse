# Projet_IF37 : MobiliVRse

**Membres du groupe :** Maxence JAULIN, Nicolas MORAIS, Thibault PAVEE, Pauline POMAS
**Semestre :** A21


### Description

Ce projet a été réalisé dans le cadre de l'UE IF37 "Conception responsable de systèmes interactifs" pour l'Université de Technologie de Troyes. L'objectif de ce projet est de permettre de répondre à la problématique suivante : Comment permettre d'améliorer l’accessibilité des espaces aux personnes éloignées géographiquement en conservant une immersion importante ?

Le dépôt GIT HUB est un outil de stockage du projet permettant de contenir toutes les applets développés et les codes utilisés.


## Installation

Afin de disposer de la solution réalisée, il faut tout d'abord configurer la Raspberry Pi 4 en installant le système d'exploitation dessus (OS). Ensuite plusieurs modules indépendants sont à installer dessus avant de pouvoir exécuter les commandes pour le déplacement du module mais également du lancement du stream. Nous avons utilisé PuTTY pour communiquer en SSH avec le module sur le port 22 et réaliser les installations

### Module de déplacement

Pour notre projet, nous avons reçu un module de déplacement contrôlable avec une Raspberry Pi. Nous n'allons pas revenir sur le montage du robot (expliqué dans le User Manual disponible dans le ./doc/picar-4wd du dépôt GIT) mais seulement sur la partie configuration de l'application sur la Raspberry.

Le modèle du robot est le suivant : Picar-4wd de chez Sunfounder.

Après installation de l'OS sur une carte micro SD, placez la carte dans la Raspberry puis tapez les commandes suivantes pour installer le programme de contrôle du robot depuis le dossier ./home/pi :

	$ cd /home/pi
	$ git clone https://github.com/sunfounder/picar-4wd

Entrez ensuite dans le dossier ./home/pi/picar-4wd.

	$ cd /home/pi/picar-4wd/
	$ sudo python3 setup.py install

L'installation du module de déplacement est finalisé après cette étape. Pour plus d'informations, le manuel d'utilisation rédigé par Sunfounder donne plus de détails sur l'utilisation de celui-ci.

### Module de streaming

    $ node cli.js simulate <pathOfTestFile>
    **Exemple:** $ node cli.js simulate ./data/ex1.gift

### Module VR


## Execution

**Module de déplacement**


**Module de streaming**






## Version

### 1.0.0
- Added a README.md


## TODO

- 


## Context

Ce projet a été réalisé dans le cadre d'un cours sur la conception de systèmes intéractifs ([IF37](https://moodle.utt.fr/course/view.php?id=2184)) animé par Mme. Di Loreto à [l 'Université de Technologie de Troyes (UTT)](https://www.utt.fr).


## Copyright

Copyright Maxence JAULIN