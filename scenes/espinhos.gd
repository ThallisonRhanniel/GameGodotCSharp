extends Area2D


func _on_body_entered(body: Node2D) -> void:
	if body.name == "Player":
		call_deferred("reload_scene")
	pass # Replace with function body.

func reload_scene():
	get_tree().reload_current_scene()
