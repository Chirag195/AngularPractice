import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms'; 
@Component({
  selector: 'app-register',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './register.html',
  styleUrls: ['./register.css'],
})
export class Register {
  registerForm: FormGroup;
   defaultName:string = "Chirag";
   constructor(private fb: FormBuilder) {
    this.registerForm = this.fb.group({
      name: [this.defaultName]
    });
  }
  onsubmit() {
   // handle submit — show form value
   alert(JSON.stringify(this.registerForm.value));
  }
}
