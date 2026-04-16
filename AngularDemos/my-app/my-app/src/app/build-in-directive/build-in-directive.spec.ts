import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BuildInDirective } from './build-in-directive';

describe('BuildInDirective', () => {
  let component: BuildInDirective;
  let fixture: ComponentFixture<BuildInDirective>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [BuildInDirective],
    }).compileComponents();

    fixture = TestBed.createComponent(BuildInDirective);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
