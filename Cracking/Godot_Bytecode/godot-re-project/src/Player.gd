extends KinematicBody

export var mouse_sensitivity = 0.1
export var speed = 14
export var sprint_bonus = 8

onready var camera_pivot = $CameraPivot

var velocity = Vector3.ZERO

func _ready():
	Input.set_mouse_mode(Input.MOUSE_MODE_CAPTURED)

func _input(event):
	if event is InputEventMouseMotion:
		rotate_y(deg2rad( - event.relative.x * mouse_sensitivity))
		camera_pivot.rotate_x(deg2rad( - event.relative.y * mouse_sensitivity))
		camera_pivot.rotation.x = clamp(camera_pivot.rotation.x, deg2rad( - 80), deg2rad(80))

func _physics_process(delta):
	var direction = Vector3.ZERO
	if Input.is_action_pressed("move_left"):
		direction -= transform.basis.x
	if Input.is_action_pressed("move_right"):
		direction += transform.basis.x
	if Input.is_action_pressed("move_forward"):
		direction -= transform.basis.z
	if Input.is_action_pressed("move_backward"):
		direction += transform.basis.z
	
	if is_on_floor() and Input.is_action_pressed("jump"):
		velocity.y += 20
	
	if direction != Vector3.ZERO:
		direction = direction.normalized()
		$Pivot.look_at(translation + direction, Vector3.UP)
	
	var current_speed = speed
	if Input.is_action_pressed("sprint"):
		current_speed += sprint_bonus
	
	velocity.x = direction.x * current_speed
	velocity.z = direction.z * current_speed
	velocity.y -= 60 * delta
	
	velocity = move_and_slide(velocity, Vector3.UP)
