import pygame

# is_game_running = None
# screen = None
# levelnumber = None
window_width = 800
window_height = 600

def run():
    global screen, is_game_running, levelnumber

    is_game_running = True
    levelnumber = 1

    pygame.init()

    screen = pygame.display.set_mode([window_width, window_height])