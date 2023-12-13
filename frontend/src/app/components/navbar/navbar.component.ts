import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MenubarModule } from 'primeng/menubar'
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'mcrs-navbar',
  standalone: true,
  imports: [CommonModule, MenubarModule],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {

  items: MenuItem[] = [
    {
      label: "Dashboard",
      url: ""
    },
    {
      label: "Targets",
      url: "targets"
    },
  ]
}
