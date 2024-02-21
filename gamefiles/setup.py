import pygame

# is_game_running = None
# screen = None
# levelnumber = None

def run():
    global screen, is_game_running, levelnumber, window_width, window_height

    is_game_running = True
    levelnumber = 1

    window_width = 1280
    window_height = 720

    pygame.init()

    screen = pygame.display.set_mode([window_width, window_height])