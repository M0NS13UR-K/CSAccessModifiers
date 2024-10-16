Very confusing at first but with practice it can be understood.

![image](https://github.com/user-attachments/assets/46e5b7aa-dfe9-41ac-84a4-a0317237534b)

Use the picture above but here are the textbook definitions to understand the scope of access modifiers in case the picture doesn't load:

public	
Accessible from anywhere in the program or other projects/assemblies	
- Fully open to all other classes and assemblies. 
- Members (fields, methods, etc.) can be accessed from outside the class and from other assemblies/projects.


private	
Accessible only within the same class	
- Completely hidden from other classes and the outside world.
- Only accessible within the class where it is defined. 
- Cannot be accessed by derived classes.

protected	
Accessible within the same class and derived (inherited) classes	
- Hidden from outside classes but accessible in subclasses.
- Used to restrict access to inheritance hierarchies.
- Not accessible by objects or classes outside the inheritance chain.
  
internal	
Accessible within the same assembly (project), but not from other assemblies	
- Members are accessible from other classes in the same project.
- Hidden from other projects/assemblies.
- Use when you want access limited to the current assembly/project.
  
protected internal	
Accessible within the same assembly and derived classes (even from another assembly)	
- Combines protected and internal.
- Accessible by derived classes, whether they are in the same assembly or another assembly.
- Accessible within the same assembly, too.
  
private protected
Accessible only within the same class or derived classes in the same assembly	
- Combines private and protected.
- Accessible by derived classes only if they are in the same assembly.
- Hidden from derived classes outside the assembly.
  
