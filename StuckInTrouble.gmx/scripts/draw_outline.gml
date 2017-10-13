object = argument[0]
thickness = argument[1]
colour = argument[2]

draw_sprite(object, 0, x, y)
draw_set_color(colour)

if !place_meeting(x, y - 1, object) {
    draw_line_width(x, y, x + 32, y, thickness)
}
if !place_meeting(x, y + 1, object) {
    draw_line_width(x, y + 32, x + 32, y + 32, thickness)
}
if !place_meeting(x - 1, y, object) {
    draw_line_width(x, y, x, y + 32, thickness)
}
if !place_meeting(x + 1, y, object) {
    draw_line_width(x + 32, y, x + 32, y + 32, thickness)
}
