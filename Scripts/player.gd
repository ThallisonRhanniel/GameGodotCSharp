extends CharacterBody2D


const SPEED = 300.0
const JUMP_VELOCITY = -400.0
const gravidade = 10

#chamado só na priemira vez que abr eo jogo
func _ready() -> void:
	print("Primeira vez")

func _process(delta: float) -> void:
	
	if !is_on_floor():
		velocity.y += gravidade
	
	
	if Input.is_action_pressed("ui_right"):
		velocity.x =  SPEED
		$Sprite2D.flip_h = false
	elif Input.is_action_pressed("ui_left"):
		velocity.x =  -SPEED
		$Sprite2D.flip_h = true
	else:
		velocity.x = 0
	
	# Se eu segurar o botão para o lado, ele é chamado infinitamente
	#var direction := Input.get_axis("ui_left", "ui_right")
	#if direction:
		#velocity.x = direction * SPEED
		#$Sprite2D.flip_h = false
	#else:
		#velocity.x = move_toward(velocity.x, 0, SPEED)	
		#$Sprite2D.flip_h = true
		
	#esse just pressed precisa apertar novamente novamente para ser acionado
	if is_on_floor() and Input.is_action_just_pressed("ui_up"):
		velocity.y -= 300
		
	
	move_and_slide()


#func _physics_process(delta: float) -> void:
	## Add the gravity.
	#if not is_on_floor():
		#velocity.y += gravidade #velocity += get_gravity() * delta
#
##velocity += get_gravity() * delta
	## Handle jump.
	##if Input.is_action_just_pressed("ui_accept") and is_on_floor():
		##velocity.y = JUMP_VELOCITY
#
	## Get the input direction and handle the movement/deceleration.
	## As good practice, you should replace UI actions with custom gameplay actions.
	##var direction := Input.get_axis("ui_left", "ui_right")
	##if direction:
		##velocity.x = direction * SPEED
	##else:
		##velocity.x = move_toward(velocity.x, 0, SPEED)
#
	#move_and_slide()
