Jeu du Pendu en C#

Description

Ce projet implémente le célèbre jeu du pendu dans un programme console en C#. Le but du jeu est de deviner un mot secret en proposant des lettres une par une avant que le nombre maximal d'erreurs ne soit atteint.

Le jeu est conçu pour être simple, interactif et amusant, et peut être utilisé pour s'exercer en orthographe ou simplement pour se divertir.

Fonctionnalités

    Choix du mot secret :
    Le mot peut être prédéfini ou sélectionné aléatoirement à partir d'une liste de mots.
    Affichage interactif :
    Le mot à deviner est affiché sous forme de tirets (_ _ _ _ _), les lettres découvertes sont dévoilées au fur et à mesure.
    Gestion des erreurs :
    Chaque lettre incorrecte réduit le nombre d'essais restants.
    Conditions de victoire et défaite :
    L'utilisateur gagne s'il devine le mot avant d'épuiser tous ses essais.
    L'utilisateur perd si le nombre maximal d'erreurs est atteint.

Fonctionnement

Étapes du jeu :

    Initialisation :
        Vous choisissez un mot secret.
    Déroulement du jeu :
        L'utilisateur propose une lettre.
        Si la lettre est correcte, elle est révélée dans le mot.
        Si la lettre est incorrecte, une erreur est comptabilisée.
    Affichage en temps réel :
        Le mot partiellement découvert (avec les lettres trouvées) est affiché.
        Le nombre d'erreurs restantes et les lettres déjà essayées sont également affichés.
    Fin du jeu :
        Victoire : L'utilisateur a deviné toutes les lettres du mot.
        Défaite : Les vies sont écoulées et le jeu s'arrête.
