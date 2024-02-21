import pygame

from gamefiles.setup import *
from gamefiles.levels import *

def run():
    global running, screen, levelnumber

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False

    level(levelnumber)

    

setup()

while running:
    run()

pygame.quit()