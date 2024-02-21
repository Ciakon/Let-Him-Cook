import gamefiles.setup as setup
import pygame

def play_level(levelnumber):

    if levelnumber == 1:
        level_1()

def level_1():
    setup.screen.fill("gray")

    
    # draw cooking pan
    pygame.draw.circle(setup.screen, "black", (setup.window_width / 2, setup.window_height / 2), 75)

    



    pygame.display.flip()