import pygame

#from gamefiles.setup import setup2, running, screen, levelnumber
#from gamefiles.levels import level, levelnumber

import gamefiles.setup as setup
import gamefiles.levels as levels

def run():

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            setup.is_game_running = False

    levels.play_level(setup.levelnumber)

setup.run()

while setup.is_game_running:
    run()

pygame.quit()